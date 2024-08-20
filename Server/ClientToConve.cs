using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;


namespace Server
{
    public partial class Form1 : Form
    {
        public string[] ReadLines;
        bool initialFlag = true;
        string receivedPath = string.Empty;
        enum DataPacketType { TEXT = 1, IMAGE };
        int dataType = 0;
        string textData = string.Empty;
        
        public Form1()
        {           
            InitializeComponent();
            Thread t_handler = new Thread(StartListening);
            t_handler.IsBackground = true;
            t_handler.Start();
           
        } 
        
        private void Form1_Load(object sender, EventArgs e)
        {
                     
            ReadLines= File.ReadAllLines(@".\test.txt", Encoding.Default);
            checkedListBox1.Items.AddRange(ReadLines);            
            richTextBox1.AppendText(checkedListBox1.CheckedItems.ToString());

        }
        


        public static ManualResetEvent allDone = new ManualResetEvent(false);
        //하나 이상의 대기중인 쓰레드에 이벤트가 발생했음을 나타냄 

        public void StartListening()
        {

            IPEndPoint localEP = new IPEndPoint(IPAddress.Any, 9050);
            //IP Endpoint(종단점 -> IP주소 및 포트 선언)
            Socket listener = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp); 
            //Socket 열어주기 

            try
            {
                listener.Bind(localEP); //주소 할당
                listener.Listen(10); // 연결대기 

                while (true)
                {
                    allDone.Reset(); //스레드가 차단되어 더이상 신호가 없다.
                    listener.BeginAccept(new AsyncCallback(AcceptCallback), listener); //Client측에 오는 요청을 받아들인다
                    //AsyncCallback :대리자를 사용하여 비동기 작업 종료 -> 쓰레드가 끝나지 않으면 다른 CPU 활용하라는 거
                    allDone.WaitOne(); //신호의 상태 확인 있으면 True  아니면 false 반환 
                }
            }
            catch (SocketException se)
            {
                Trace.WriteLine(string.Format("SocketException :{0}", se.Message));
            }
            catch (Exception ex)
            {
                Trace.WriteLine(string.Format("Exception :{0}", ex.Message));
            }
        }

        public void AcceptCallback(IAsyncResult ar)
        {
            allDone.Set();

            Socket listener = ar.AsyncState as Socket;
            Socket handler = listener.EndAccept(ar);

            StateObject state = new StateObject();
            state.workSocket = handler;
            handler.BeginReceive(state.buffer, 0, StateObject.BufferSize, 0, new AsyncCallback(ReadCallback), state);
            initialFlag = true;
        }


        private void ReadCallback(IAsyncResult ar)
        {
            int fileNameLen = 0;
            string content = string.Empty;
            StateObject state = ar.AsyncState as StateObject;
            Socket handler = state.workSocket;
            int bytesRead = handler.EndReceive(ar);

            if (bytesRead > 0)
            {
                if (initialFlag)
                {
                    dataType = BitConverter.ToInt32(state.buffer, 0);
                    if (dataType == (int)DataPacketType.IMAGE)
                    {
                        fileNameLen = BitConverter.ToInt32(state.buffer, 4);
                        string fileName = Encoding.UTF8.GetString(state.buffer, 8, fileNameLen);

                        string pathUser = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
                        string pathDownload = Path.Combine(pathUser, "Downloads");

                        receivedPath = Path.Combine(pathDownload, fileName);
                       
                        if (File.Exists(receivedPath))
                            File.Delete(receivedPath);
                    }
                    else if (dataType == (int)DataPacketType.TEXT)
                    {
                        textData = Encoding.UTF8.GetString(state.buffer, 4, bytesRead - 4);
                        handler.BeginReceive(state.buffer, 0, StateObject.BufferSize, 0, new AsyncCallback(ReadCallback), state);
                       
                    }
                }

                if (dataType == (int)DataPacketType.IMAGE)
                {
                    BinaryWriter bw = new BinaryWriter(File.Open(receivedPath, FileMode.Append));
                    if (initialFlag)
                        bw.Write(state.buffer, 8 + fileNameLen, bytesRead - (8 + fileNameLen));
                    else
                        bw.Write(state.buffer, 0, bytesRead);

                    initialFlag = false;
                    bw.Close();
                    handler.BeginReceive(state.buffer, 0, StateObject.BufferSize, 0, new AsyncCallback(ReadCallback), state);
                }
            }
            else
            {
                if (dataType == (int)DataPacketType.IMAGE)
                {
                    pictureBox1.ImageLocation = receivedPath;
                    pictureBox2.ImageLocation = receivedPath;

                }
                else if (dataType == (int)DataPacketType.TEXT)
                {
                    checkedListBox1.Items.Add(textData);
                }

            }
        }




        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorMoveNextItem_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < checkedListBox1.CheckedItems.Count ; i++)
            {
                richTextBox1.AppendText(checkedListBox1.CheckedItems[i].ToString() + "\n");
            }
           
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void splitContainer2_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

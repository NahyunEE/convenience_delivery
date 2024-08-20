using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Net;
using System.Threading;
using System.IO;



namespace Convenience
{
    public partial class SecondPage : Form, IStoreName
    {
        public string storeName { get; set; }

        ConveStore con;
        CU cu;
        SEVEN seven;
        GS gs;

        int flag;//comboBox_Category에서 얻은 카테고리 매개변수 

        SortProduct sort; //코드가 복잡해서 따로 클래스화 시킴

        //소켓관련 변수선언(편의점 -> 서버)
        string m_splitter = "'\\'";
        string m_fName = string.Empty;
        string[] m_split = null;
        byte[] m_clientData = null;
        enum DataPacketType { TEXT = 1, IMAGE };
        //
        int i;//리스트 박스에 초기값을 한번만 넣기위해 선언

       

        public SecondPage()
        {
            con = new ConveStore();
            InitializeComponent();
        }

       

        //재고현황 업데이트
        //이 코드는 접어서 보기를 권장함
        private void btn_Updating_Click(object sender, EventArgs e)
        {
            if (i == 0)
            {
                if (storeName == "CU")
                {
                    cu = new CU();


                    foreach (string key in cu.PB.Keys)
                    {

                        listBox_PB.Items.Add(key);

                    }

                    foreach (string key in cu.Instant.Keys)
                    {
                        listBox_Instant.Items.Add(key);
                    }

                    foreach (string key in cu.Household.Keys)
                    {
                        listBox_House.Items.Add(key);
                    }

                    foreach (string key in cu.Drink.Keys)
                    {
                        listBox_Drink.Items.Add(key);
                    }

                    foreach (string key in cu.Easy_Eats.Keys)
                    {
                        listBox_Easy.Items.Add(key);
                    }

                    foreach (string key in cu.Dessert.Keys)
                    {
                        listBox_Dessert.Items.Add(key);
                    }
                }
                else if (storeName == "SEVEN")
                {

                    seven = new SEVEN();

                    foreach (string key in seven.PB.Keys)
                    {
                        listBox_PB.Items.Add(key);
                    }

                    foreach (string key in seven.Instant.Keys)
                    {
                        listBox_Instant.Items.Add(key);
                    }

                    foreach (string key in seven.Household.Keys)
                    {
                        listBox_House.Items.Add(key);
                    }

                    foreach (string key in seven.Drink.Keys)
                    {
                        listBox_Drink.Items.Add(key);
                    }

                    foreach (string key in seven.Easy_Eats.Keys)
                    {
                        listBox_Easy.Items.Add(key);
                    }

                    foreach (string key in seven.Dessert.Keys)
                    {
                        listBox_Dessert.Items.Add(key);
                    }
                }
                else if (storeName == "GS")
                {
                    gs = new GS();

                    foreach (string key in gs.PB.Keys)
                    {
                        listBox_PB.Items.Add(key);
                    }

                    foreach (string key in gs.Instant.Keys)
                    {
                        listBox_Instant.Items.Add(key);
                    }

                    foreach (string key in gs.Household.Keys)
                    {
                        listBox_House.Items.Add(key);
                    }

                    foreach (string key in gs.Drink.Keys)
                    {
                        listBox_Drink.Items.Add(key);
                    }

                    foreach (string key in gs.Easy_Eats.Keys)
                    {
                        listBox_Easy.Items.Add(key);
                    }

                    foreach (string key in gs.Dessert.Keys)
                    {
                        listBox_Dessert.Items.Add(key);
                    }

                }
                i = 1;
            }
            else
            {
                getItem();
            }



        }
           
        
        //소켓관련메소드 (편의점 -> 서버)
        //신제품 등록
        private void SendData()
        { 
                Socket clientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);//소켓 생성

                byte[] fileName = Encoding.UTF8.GetBytes(m_fName); //4byte
                byte[] fileData = File.ReadAllBytes(tB_Browse.Text);
                byte[] fileNameLen = BitConverter.GetBytes(fileName.Length);//4byte
                byte[] fileType = BitConverter.GetBytes((int)DataPacketType.IMAGE); //4byte
                                                                                    // IMAGE(4 byte) + 파일이름(4 byte) + 파일이름길이(4 byte) + 데이타 길이
                m_clientData = new byte[fileType.Length + 4 + fileName.Length + fileData.Length];

                fileType.CopyTo(m_clientData, 0);
                fileNameLen.CopyTo(m_clientData, 4);
                fileName.CopyTo(m_clientData, 8);
                fileData.CopyTo(m_clientData, 8 + fileName.Length);

                clientSocket.Connect(IPAddress.Parse("203.230.193.226"), 9050);//server측에 연결 요청
                clientSocket.Send(m_clientData);
                clientSocket.Close();
        }
        private void btn_Send_Click(object sender, EventArgs e)
        {
         Thread t_handler = new Thread(SendData);
         t_handler.IsBackground = true;
         t_handler.Start();
        }
        private void btn_send_text_Click(object sender, EventArgs e)
        {
            Socket clientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            byte[] textData = Encoding.UTF8.GetBytes(tB_ProductName.Text);
            byte[] fileType = BitConverter.GetBytes((int)DataPacketType.TEXT);
            // TEXT(4 byte) + 데이타 길이
            m_clientData = new byte[fileType.Length + textData.Length];

            fileType.CopyTo(m_clientData, 0);
            textData.CopyTo(m_clientData, 4);

            clientSocket.Connect(IPAddress.Parse("203.230.193.226"), 9050);
            clientSocket.Send(m_clientData);
            clientSocket.Close();
        }
        private void btn_Bowse_Click(object sender, EventArgs e)
        {
            char[] delimeter = m_splitter.ToCharArray();

            openFileDialog1.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            openFileDialog1.ShowDialog();

            tB_Browse.Text = openFileDialog1.FileName;
            picBox_Product.ImageLocation = openFileDialog1.FileName;

            m_split = tB_Browse.Text.Split(delimeter);
            int limit = m_split.Length;

            m_fName = m_split[limit - 1].ToString();

            if (tB_Browse.Text != null)
                btn_send_text.Enabled = true;
        }

        //신제품 등록 후 리스트박스에 추가
        private void getItem()
        {
            if (storeName == "CU")
            {
                string item = tB_ProductName.Text;
                sort.getItem(storeName, flag, item);
            }
            else if (storeName == "SEVEN")
            {
                string item = tB_ProductName.Text;
                sort.getItem(storeName, flag, item);

            }
            else if (storeName == "GS")
            {
                string item = tB_ProductName.Text;
                sort.getItem(storeName, flag, item);
            }
        }
    }
    } 

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using OnBarcode.Barcode;


namespace Barcode
{
    public partial class Form1 : Form
    {
        int latestbarcode;

        private bool IsItemValid()
        {
            if (txtBox_NewItemName.Text == "")
            {
                MessageBox.Show("Please fill up all details.");
                return false;
            }

            else
            {
                return true;
            }
        }

        private bool IsBarcodeValid()
        {
            if (txtBox_Barcode.Text == "")
            {
                MessageBox.Show("Please fill up all details.");
                return false;
            }

            else
            {
                return true;
            }
        }

        private bool IsNewItemValid()
        {
            if (txtBox_NewItemName.Text == "")
            {
                MessageBox.Show("Please fill up all details.");
                return false;
            }

            else
            {
                return true;
            }
        }

        private void DrawBarcode()
        {
            
        }

        public int GenerateBarcode()
        {
            using (SqlConnection conn = new SqlConnection("Data Source=DESKTOP-Q1K44I8\\SA;Initial Catalog=barcode;Integrated Security=True"))
            {
                using (SqlCommand Barcodecmd = new SqlCommand())
                {
                    Barcodecmd.Connection = conn;
                    Barcodecmd.CommandType = CommandType.Text;
                    Barcodecmd.CommandText = "select ItemCode from Table_Item order by ItemCode DESC";

                    conn.Open();

                    using (SqlDataReader read = Barcodecmd.ExecuteReader())
                    {
                        read.Read();
                        latestbarcode = read.GetInt32(0) + 1;
                    }

                    conn.Close();

                    return latestbarcode;
                }
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'barcodeDataSet.Table_Item' table. You can move, or remove it, as needed.
            this.table_ItemTableAdapter.Fill(this.barcodeDataSet.Table_Item);

        }

        /*private void btn_Search_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection("Data Source=DESKTOP-Q1K44I8\\SA;Initial Catalog=barcode;Integrated Security=True"))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "select ItemName, ItemCode, ItemWeight from Table_Item WHERE ItemBarcode = " + txtBox_Barcode.Text;

                    try
                    {
                        conn.Open();

                        using (SqlDataReader read = cmd.ExecuteReader())
                        {
                            read.Read();

                            txtBox_ItemName.Text = (read["ItemName"].ToString());
                            txtBox_ItemCode.Text = (read["ItemCode"].ToString());
                            txtBox_ItemWeight.Text = (read["ItemWeight"].ToString());

                        }

                        cmd.ExecuteNonQuery();

                    }
                    catch
                    {
                        //MessageBox.Show("Search Failed");
                    }
                    finally
                    {
                        conn.Close();
                    }
                }

            }
        }*/

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            txtBox_Barcode.Clear();
            txtBox_ItemName.Clear();
            txtBox_ItemCode.Clear();
            txtBox_ItemWeight.Clear();
        }

        private void btn_AddItem_Click(object sender, EventArgs e)
        {
            //if (IsNewItemValid())
            //{
            using (SqlConnection conn = new SqlConnection("Data Source=DESKTOP-Q1K44I8\\SA;Initial Catalog=barcode;Integrated Security=True"))
            {
                for (int i = 0; i < 5; i++)
                {
                        using (SqlCommand Itemcmd = new SqlCommand("dbo.InsertItem", conn))
                        {
                            Itemcmd.CommandType = CommandType.StoredProcedure;
                            
                            //Itemcmd.CommandText = "begin transaction insert into Table_Item with (TABLOCK, HOLDLOCK) (ItemName, ItemWeight, ItemBarcode) values (@ItemName, @ItemWeight, @ItemBarcode) waitfor delay '00:00:01' commit transaction ";
                            
                            Itemcmd.Parameters.AddWithValue("@ItemName", txtBox_NewItemName.Text = "JWen"+(i+1));
                            Itemcmd.Parameters.AddWithValue("@ItemWeight", txtBox_NewItemWeight.Text = "100");
                            //Itemcmd.Parameters.AddWithValue("@ItemBarcode", "BAR_" + (i+1));
                            //Itemcmd.Parameters.AddWithValue("@ItemBarcode", "BAR_" + GenerateBarcode());

                            try
                            {
                                conn.Open();
                                Itemcmd.ExecuteNonQuery();
                                //MessageBox.Show("Create New Item Done");

                            }

                            catch
                            {
                                MessageBox.Show("Create New Item Failed");
                            }
                            finally
                            {
                                conn.Close();
                            }
                        }

                        using (SqlCommand Barcodecmd = new SqlCommand())
                        {
                            Barcodecmd.Connection = conn;
                            Barcodecmd.CommandType = CommandType.Text;
                            Barcodecmd.CommandText = "select ItemBarcode from tblItem order by ItemCode DESC";

                            try
                            {
                                conn.Open();

                                using (SqlDataReader read = Barcodecmd.ExecuteReader())
                                {
                                    read.Read();
                                    //latestbarcode = read.GetInt32(0) + 1;

                                    // Create linear barcode object
                                    Linear barcode = new Linear();
                                    // Set barcode symbology type to Code-128
                                    barcode.Type = BarcodeType.CODE128;
                                    // Set barcode data to encode
                                    barcode.Data = read["ItemBarcode"].ToString();
                                    // Set barcode bar width (X dimension) in pixel
                                    barcode.X = 1;
                                    // Set barcode bar height (Y dimension) in pixel
                                    barcode.Y = 60;
                                    // Draw & print generated barcode to png image file
                                    barcode.drawBarcode("C:/Users/Jwen/Desktop/Item_" + barcode.Data + ".jpg");
                                }
                                //MessageBox.Show("Create New Barcode Done");
                            }
                            catch
                            {
                                MessageBox.Show("Create New Barcode Failed");
                            }
                            finally
                            {
                                conn.Close();
                            }
                        }

                        txtBox_NewItemName.Clear();
                        txtBox_NewItemWeight.Clear();                        
                }
            }
        }

        private void btn_Search1_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection("Data Source=DESKTOP-Q1K44I8\\SA;Initial Catalog=barcode;Integrated Security=True"))
            {
                using (SqlCommand cmd = new SqlCommand("select ItemCode, ItemName, ItemWeight from Table_Item where ItemBarcode = @ItemBarcode", conn))
                {
                    cmd.Parameters.Add(new SqlParameter("@ItemBarcode", txtBox_Barcode.Text));
                    
                    try
                    {
                        conn.Open();

                        using (SqlDataReader read = cmd.ExecuteReader())
                        {
                            read.Read();

                            txtBox_ItemName.Text = (read["ItemName"].ToString());
                            txtBox_ItemCode.Text = (read["ItemCode"].ToString());
                            txtBox_ItemWeight.Text = (read["ItemWeight"].ToString());

                        }

                    }
                    catch
                    {
                        //MessageBox.Show("Search Failed");
                    }
                    finally
                    {
                        conn.Close();
                    }
                }

            }
        }
    }
}

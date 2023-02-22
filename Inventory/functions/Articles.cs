using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;

namespace Inventory.functions
{
    class Articles
    {
        components.Connection connection = new components.Connection();
        components.Values val = new components.Values();

        public void loadArticleToCombobox (ComboBox mComboBox, string category)
        {
            try
            {

                mComboBox.Items.Clear();

                using (MySqlConnection con = new MySqlConnection(connection.conString))
                {
                    con.Open();
                    string sql = @"SELECT * FROM inventorydb.tblarticles WHERE articlecategory ='" + category + "'";

                    using (MySqlCommand cmd = new MySqlCommand(sql, con))
                    {
                        MySqlDataAdapter da = new MySqlDataAdapter();
                        da.SelectCommand = cmd;
                        DataTable dt = new DataTable();
                        dt.Load(cmd.ExecuteReader());
                        DataRow dr = null;

                        for (int i = 0; i < dt.Rows.Count; i++)
                        {
                            dr = dt.Rows[i];
                            mComboBox.Items.Add(dr[2].ToString());
                        }
                        con.Close();
                    }

                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error loading article data:" + e);
            }
        }

        public bool addArticle(string mCategory, string mArticleName)
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(connection.conString))
                {
                    string sql = @"INSERT INTO inventorydb.tblarticles(articlecategory, articlename) VALUES (@article_category, @article_name)";

                    using (MySqlCommand cmd = new MySqlCommand(sql, con))
                    {
                        cmd.Parameters.AddWithValue("@article_category", mCategory);
                        cmd.Parameters.AddWithValue("@article_name", mArticleName);

                        cmd.Connection.Open();
                        MySqlDataReader dr;
                        dr = cmd.ExecuteReader();
                        dr.Close();

                        return true;
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error adding article data: " + e);
                return false;
            }
        }

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HanziDemo
{
    public partial class Form1 : Form
    {
        private string db = ""; //SQLite database
        private string chineseTextProject = @"http://ctext.org/dictionary.pl?if=en&char=";

        public Form1()
        {
            db = "Data Source=" + Application.StartupPath + @"\searchable.db;Version=3";
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataSet ds = getStrokes();
            if (ds == null)
            {
                MessageBox.Show("数据库文件异常！", "提示");
                System.Environment.Exit(0);
            }
            this.cbo_stroke.DisplayMember = "stroke";
            this.cbo_stroke.ValueMember = "stroke";
            this.cbo_stroke.DataSource = ds.Tables[0].DefaultView;
        }

        DataSet getStrokes()
        {

            DataSet ds = new DataSet();
            try
            {
                SQLiteConnection conn = new SQLiteConnection(db);//创建数据库实例，指定文件位置  
                string sql = "select distinct stroke from radical order by stroke ";
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(sql, conn);
                adapter.Fill(ds);
            }
            catch (SQLiteException ex)
            {
                return null;
            }
            catch (Exception ex)
            {
                return null;
            }
            return ds;
        }

        DataSet getRadicals(string count)
        {
            DataSet ds = new DataSet();
            try
            {
                SQLiteConnection conn = new SQLiteConnection(db);//创建数据库实例，指定文件位置  
                string sql = "select radical from radical where stroke=" + count.ToString();
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(sql, conn);
                adapter.Fill(ds);
            }
            catch (SQLiteException ex)
            {
                return null;
            }
            catch (Exception ex)
            {
                return null;
            }
            return ds;
        }

        private void cbo_stroke_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbo_stroke.SelectedIndex == -1)
                return;

            string stroke = cbo_stroke.SelectedValue.ToString();
            DataSet ds = getRadicals(stroke);
            if (ds != null)
            {
                this.lst_radical.DisplayMember = "radical";
                this.lst_radical.ValueMember = "radical";
                this.lst_radical.DataSource = ds.Tables[0].DefaultView;
            }
        }

        DataSet getChar(string radical)
        {
            radical = radical.Trim();
            DataSet ds = new DataSet();
            try
            {
                SQLiteConnection conn = new SQLiteConnection(db);//创建数据库实例，指定文件位置  
                string sql = "select character from character where radical='" + radical + "'";
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(sql, conn);
                adapter.Fill(ds);
            }
            catch (SQLiteException ex)
            {
                return null;
            }
            catch (Exception ex)
            {
                return null;
            }
            return ds;
        }

        private void lst_radical_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.lst_radical.SelectedIndex == -1)
                return;

            string radical = this.lst_radical.Text;

            DataSet ds = getChar(radical);
            if (ds != null)
            {

                this.lst_char.DisplayMember = "character";
                this.lst_char.ValueMember = "character";
                this.lst_char.DataSource = ds.Tables[0].DefaultView;
            }
        }

        private void lst_char_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.lst_radical.SelectedIndex == -1)
                return;
            lbl_char.Text = this.lst_char.Text;
            DataSet ds = getComponent(this.lst_char.Text);
            if (ds != null)
            {

                this.lst_component.DisplayMember = "component";
                this.lst_component.ValueMember = "component";
                this.lst_component.DataSource = ds.Tables[0].DefaultView;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            lbl_char.Text = this.tb_input.Text;
            this.webBrowser1.Navigate(chineseTextProject);
            DataSet ds = getComponent(this.tb_input.Text);
            DataRow dr = ds.Tables[0].NewRow();
            dr["component"] = this.tb_input.Text;
            ds.Tables[0].Rows.Add(dr);
            if (ds != null)
            {
                if(ds.Tables[0].Rows.Count == 0)
                {
                    this.lst_component.DataSource = null;
                    this.lst_character.DataSource = null;
                    return;
                }
                this.lst_component.DisplayMember = "component";
                this.lst_component.ValueMember = "component";
                this.lst_component.DataSource = ds.Tables[0].DefaultView;
            }
        }

        private void lbl_char_Click(object sender, EventArgs e)
        {
            string character = lbl_char.Text;

            string url = chineseTextProject + System.Web.HttpUtility.UrlEncode(character);
            this.webBrowser1.Navigate(url);
        }

        DataSet getComponent(string character)
        {
            character = character.Trim();
            DataSet ds = new DataSet();
            try
            {
                SQLiteConnection conn = new SQLiteConnection(db);//创建数据库实例，指定文件位置  
                string sql = "select component from component where character='" + character + "'";
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(sql, conn);
                adapter.Fill(ds);
            }
            catch (SQLiteException ex)
            {
                return null;
            }
            catch (Exception ex)
            {
                return null;
            }
            return ds;
        }

        DataSet getCharacter(string component)
        {
            component = component.Trim();
            DataSet ds = new DataSet();
            try
            {
                SQLiteConnection conn = new SQLiteConnection(db);//创建数据库实例，指定文件位置  
                string sql = "select character from component where component='" + component + "'";
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(sql, conn);
                adapter.Fill(ds);
            }
            catch (SQLiteException ex)
            {
                return null;
            }
            catch (Exception ex)
            {
                return null;
            }
            return ds;
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            this.webBrowser1.Document.Body.Style = "font-family:KaiXinSong;font-size:medium";
        }

        private void webBrowser1_ProgressChanged(object sender, WebBrowserProgressChangedEventArgs e)
        {
            progressBar1.Visible = true;
            if((e.CurrentProgress > 0) && (e.MaximumProgress > 0))
            {
                progressBar1.Maximum = Convert.ToInt32(e.MaximumProgress);
                progressBar1.Step = Convert.ToInt32(e.CurrentProgress);
                progressBar1.PerformStep();
            }
            else if (webBrowser1.ReadyState == WebBrowserReadyState.Complete)
            {
                progressBar1.Value = 0;
                progressBar1.Visible = false;
            }
        }

        private void lst_component_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.lst_component.SelectedIndex == -1)
                return;
            
            string component = this.lst_component.Text;

            DataSet ds = getCharacter(component);
            if (ds != null)
            {
                this.lst_character.DisplayMember = "character";
                this.lst_character.ValueMember = "character";
                this.lst_character.DataSource = ds.Tables[0].DefaultView;
            }
        }

        private void lst_component_Click(object sender, EventArgs e)
        {
            string character = this.lst_component.Text;

            string url = chineseTextProject + System.Web.HttpUtility.UrlEncode(character);
            this.webBrowser1.Navigate(url);
        }

        private void lst_character_Click(object sender, EventArgs e)
        {
            string character = this.lst_character.Text;

            string url = chineseTextProject + System.Web.HttpUtility.UrlEncode(character);
            this.webBrowser1.Navigate(url);
        }
    }
}

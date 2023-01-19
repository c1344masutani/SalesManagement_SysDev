using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using Microsoft.VisualBasic;

namespace SalesManagement_SysDev
{
    public partial class F_Login : Form
    {
        //入力形式チェック用クラスのインスタンス化
        DataInputFormCheck dataInputFormCheck = new DataInputFormCheck();

        public F_Login()
        {
            InitializeComponent();
        }

        private void btn_CleateDabase_Click(object sender, EventArgs e)
        {
            //データベースの生成を行います．
            //再度実行する場合には，必ずデータベースの削除をしてから実行してください．
            
            //役職マスタを生成するサンプル（1件目に管理者を追加する例）
            M_Position FirstPosition = new M_Position()
            {
                PoName = "管理者"
            };
            SalesManagement_DevContext context = new SalesManagement_DevContext();
            context.M_Positions.Add(FirstPosition);
            context.SaveChanges();
            context.Dispose();

            MessageBox.Show("テーブル作成完了");
        }

        private void Login_button_Click(object sender, EventArgs e)
        {
            string loginID = ID_textBox.Text;
            string loginPW = PW_textBox.Text;
            bool flg;

            //プログラムチェック用
            //Form frm = new F_menu2();
            //frm.ShowDialog();

            //テスト用
            if(loginID == "test" && loginPW == "test")
            {
                F_menu2.position = 1;
                F_menu2.loginname = "テスト用";

                Form frm = new F_menu2();

                Opacity = 0;

                frm.WindowState = FormWindowState.Maximized;
                frm.ShowDialog();


                this.Close();
            }


            //ユーザID・PWの入力状況チェック
            if (loginID.Trim() == "" || loginID == null || loginPW.Trim() == "" || loginPW == null)
            {
                //ID・PW未入力メッセージ
                MessageBox.Show("IDまたはPWが入力されていません");
                return;
            }
            try
            {
                

                //ユーザID・PWチェック
                var context = new SalesManagement_DevContext();
                //ユーザID・PWが存在するか
                flg = context.M_Employees.Any(x => x.EmID.ToString() == loginID && x.EmPassword == loginPW && x.EmFlag == 0);
                if(flg == true)
                {
                    var login = context.M_Employees.Single(x => x.EmID.ToString() == loginID);
                    F_menu2.position = login.PoID;
                    F_menu2.loginname = login.EmName;
                    Form frm = new F_menu2();

                    Opacity = 0;

                    frm.WindowState = FormWindowState.Maximized;
                    frm.ShowDialog();
                    

                    this.Close();
                }
                else
                {
                    MessageBox.Show("IDまたはPWが違います。");

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void PwShow_CheckedChanged(object sender, EventArgs e)
        {
            if (PwShow.Checked)
            {
                PW_textBox.PasswordChar = default(char);
            }
            else
            {
                PW_textBox.PasswordChar = '*';
            }
        }

        private void F_Login_Load(object sender, EventArgs e)
        {
            ID_textBox.Focus();
        }

        private void ID_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var context = new SalesManagement_DevContext();

            string loginID = Interaction.InputBox("管理者の社員IDを入力してください", "管理者ID確認", "", -1, -1);
            //入力されたIDが管理者かどうか判定
            bool emid_flg = context.M_Employees.Any(x => x.EmID.ToString() == loginID && x.PoID == 1 && x.EmFlag == 0);
            if(emid_flg == true)
            {
                //PWを入力・確認
                string loginPW = Interaction.InputBox("パスワードを入力してください", "パスワード確認", "", -1, -1);
                bool pw_flg = context.M_Employees.Any(x => x.EmID.ToString() == loginID && x.EmPassword == loginPW);
                if(pw_flg == true)
                {
                    F_syain.from = "login";
                    Form frm = new F_syain();

                    Opacity = 0;

                    frm.WindowState = FormWindowState.Maximized;
                    frm.ShowDialog();


                    this.Close();
                }
                else
                {
                    MessageBox.Show("パスワードが違います");
                    return;
                }
            }
            else
            {
                string loginPW = Interaction.InputBox("パスワードを入力してください", "パスワード確認", "", -1, -1);
                //初期設定用
                if (loginID == "setup" && loginPW == "setup")
                {
                    F_syain.from = "login";
                    Form frm = new F_syain();

                    Opacity = 0;

                    frm.WindowState = FormWindowState.Maximized;
                    frm.ShowDialog();


                    this.Close();
                }
                MessageBox.Show("管理者の社員IDを入力してください");
                return;
            }
            
        }

        private void F_Login_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}

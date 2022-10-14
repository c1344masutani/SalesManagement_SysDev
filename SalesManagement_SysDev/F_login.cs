﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace SalesManagement_SysDev
{
    public partial class F_Login : Form
    {
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
                    Form frm = new F_menu();

                    Opacity = 0;

                    frm.ShowDialog();

                    //開いたフォームから戻ってきたら
                    //メモリを解放する
                    frm.Dispose();
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}

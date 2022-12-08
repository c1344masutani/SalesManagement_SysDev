using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace SalesManagement_SysDev
{
    class DataInputFormCheck
    {
        ///////////////////////////////
        //メソッド名：CheckFullWidth()
        //引　数   ：文字列
        //戻り値   ：True or False
        //機　能   ：全角文字列のチェック
        //          ：全角文字列の場合True
        //          ：全角文字列でない場合False
        ///////////////////////////////
        public bool CheckFullWidth(string text)
        {
            bool flg;

            int textLength = text.Replace("\r\n", string.Empty).Length;
            int textByte = Encoding.GetEncoding("Shift_JIS").GetByteCount(text.Replace("\r\n", string.Empty));
            if (textByte != textLength * 2)
                flg = false;
            else
                flg = true;

            return flg;
        }
        ///////////////////////////////
        //メソッド名：CheckHalfAlphabetNumeric()
        //引　数   ：文字列
        //戻り値   ：True or False
        //機　能   ：半角英数字文字列のチェック
        //          ：半角文字列の場合True
        //          ：半角文字列でない場合False
        ///////////////////////////////
        public bool CheckHalfAlphabetNumeric(string text)
        {
            bool flg;

            Regex regex = new Regex("^[a-zA-Z0-9]+$");
            if (!regex.IsMatch(text))
                flg = false;
            else
                flg = true;

            return flg;
        }
        ///////////////////////////////
        //メソッド名：CheckHalfWidthKatakana()
        //引　数   ：文字列
        //戻り値   ：True or False
        //機　能   ：半角カナのチェック
        //          ：半角カナの場合True
        //          ：半角カナでない場合False
        ///////////////////////////////
        public bool CheckHalfWidthKatakana(string text)
        {
            bool flg;

            Regex regex = new Regex(@"[\uFF66-\uFF9D]");
            if (!regex.IsMatch(text))
                flg = false;
            else
                flg = true;

            return flg;
        }

        ///////////////////////////////
        //メソッド名：CheckNumeric()
        //引　数   ：文字列
        //戻り値   ：True or False
        //機　能   ：数値のチェック
        //          ：数値の場合True
        //          ：数値でない場合False
        ///////////////////////////////
        public bool CheckNumeric(string text)
        {
            bool flg;

            Regex regex = new Regex("^[0-9]+$");
            if (!regex.IsMatch(text))
                flg = false;
            else
                flg = true;

            return flg;
        }
        ///////////////////////////////
        //メソッド名：CheckMailAddress()
        //引　数   ：文字列
        //戻り値   ：True or False
        //機　能   ：メールアドレス形式のチェック
        //          ：メールアドレス形式の場合True
        //          ：メールアドレス形式でない場合False
        ///////////////////////////////
        public bool CheckMailAddress(string text)
        {
            bool flg = false;

            Regex regex = new Regex(@"^\b[\w.%+-]+@[\w.-]+\.[a-zA-Z]{2,4}\b$");
            if (!regex.IsMatch(text))
                flg = false;
            else
                flg = true;

            return flg;
        }
        ///////////////////////////////
        //メソッド名：CheckHalfChar()
        //引　数   ：文字列
        //戻り値   ：True or False
        //機　能   ：半角文字のチェック
        //          ：半角文字の場合True
        //          ：半角文字でない場合False
        ///////////////////////////////
        public bool CheckHalfChar(string text)
        {
            bool flg = false;

            Regex regex = new Regex("^[ -~]+$");
            if (!regex.IsMatch(text))
                flg = false;
            else
                flg = true;
            return flg;
        }
    }
}

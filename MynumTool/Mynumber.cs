﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace MynumTool
{
    public class Mynumber
    {
        static readonly int[] Q = { 6, 5, 4, 3, 2, 7, 6, 5, 4, 3, 2 };

        // 12桁の個人番号の有効/無効を判定
        public static bool IsValid(string duodecupleDigits)
        {
            if (!(new Regex("^[0-9]{12}$")).IsMatch(duodecupleDigits))
                return false;

            // 1～11桁目から生成したチェックデジットと12桁目が一致するかどうかを判定する
            string checkDigit = CalcCheckDigit(duodecupleDigits.Substring(0, 11));
            return duodecupleDigits[11].ToString() == checkDigit;
        }

        // 個人番号1～11桁目からチェックデジット（12桁目）を算出する
        public static string CalcCheckDigit(string undecupleDigits)
        {
            if(!(new Regex("^[0-9]{11}$")).IsMatch(undecupleDigits))
            {
                return null;
            }

            // Pn * Qn の合計値
            int sumPnxQn = 0;
            for (int i = 0; i < 11; i++)
            {
                sumPnxQn += int.Parse((undecupleDigits[i]).ToString()) * Q[i];
            }

            var mods = sumPnxQn % 11;

            // (Pn * Qn) % 11 <= 1 のときチェックデジットは 0 とする
            if (mods <= 1)
            {
                return "0";
            }
            else
            {
                return (11 - mods).ToString();
            }
        }
    }
}

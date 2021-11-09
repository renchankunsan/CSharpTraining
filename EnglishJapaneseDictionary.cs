using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Training.WorkBook.EnglishJapaneseDictionary
{
    public class EnglishJapaneseDictionary
    {
        /// <summary>
        /// 英和辞書を作ろう
        /// CreateEnglishJapaneseDicメソッド内で複数の英和辞書が作られています。
        /// 引数として辞書の種類と日本語訳したい英単語が渡されるので、適切な辞書を選んで日本語訳を出力して下さい。
        /// 表示内容は下記の通り。
        ///     ・辞書の種類が存在しないとき
        ///         →「xxという辞書は存在しません。」
        ///         例：「bikeという辞書は存在しません。」
        ///     ・辞書は存在するが翻訳対象の英単語が存在しないとき
        ///         →「xxの辞書にxxは存在しません。」
        ///         例：「animalの辞書にmonkeyは存在しません。」
        ///     ・辞書と翻訳対象が見つかったとき
        ///         →「xxの日本語名はxxです。」
        ///         例：「animalの日本語名は犬です。」
        /// </summary>
        public void ShowJapanese(string dicType, string translationTarget)
        {
            Dictionary<string, Dictionary<string, string>> EJDictionary = CreateEnglishJapaneseDic();

            // ここから下にコードを書く
            if (EJDictionary.ContainsKey(dicType))
            {
                if (EJDictionary[dicType].ContainsKey(translationTarget))
                {
                    Console.WriteLine("{0}の日本語名は{1}です。", translationTarget, EJDictionary[dicType][translationTarget]);
                }
                else
                {
                    Console.WriteLine("{0}の辞書に{1}は存在しません。", dicType, translationTarget);
                }
            }
            else
            {
                Console.WriteLine("{0}という辞書は存在しません。", dicType);
            }
        }

        /// <summary>
        /// 英和辞書作成
        /// animalというkeyに対して動物の英和辞書
        /// fruitというkeyに対して果物の英和辞書
        /// faceというkeyに対して顔のパーツの英和辞書
        /// ※変更不要
        /// </summary>
        /// <returns></returns>
        private static Dictionary<string, Dictionary<string, string>> CreateEnglishJapaneseDic()
        {
            // 動物の英和辞書を作ろう
            Dictionary<string, string> animalDic = new Dictionary<string, string>();
            animalDic["dog"] = "犬";
            animalDic["cat"] = "猫";
            animalDic["bird"] = "鳥";

            // 果物の英和辞書を作ろう
            Dictionary<string, string> fruitDic = new Dictionary<string, string>();
            fruitDic["apple"] = "りんご";
            fruitDic["grape"] = "ぶどう";
            fruitDic["peach"] = "もも";

            // 顔のパーツの英和辞書を作ろう
            Dictionary<string, string> faceDic = new Dictionary<string, string>();
            faceDic["nose"] = "鼻";
            faceDic["ear"] = "耳";
            faceDic["eye"] = "目";

            // keyに辞書名、valueに英和辞書を取るようなDictionaryの宣言
            Dictionary<string, Dictionary<string, string>> EJDictionary = new Dictionary<string, Dictionary<string, string>>();
            EJDictionary["animal"] = animalDic;
            EJDictionary["fruit"] = fruitDic;
            EJDictionary["face"] = faceDic;

            return EJDictionary;
        }



    }
}

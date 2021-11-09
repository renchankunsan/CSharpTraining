using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Training.WorkBook.HundredSquareCalc
{
    public class HundredSquareCalc
    {
        /// <summary>
        /// 百ます計算
		/// 【ルール】
		/// ・縦軸を10個、横軸を10個とする。
		/// ・縦の数字と横の数字の積を出力していく。
		/// ・<<二次元のリスト>>を用いること。
		/// ・縦軸も横軸も1-10を順番に用いる。
        /// 
		/// 【出力結果例】
		/// 1,2,3,4,5,6,7,8,9,10
		/// 2,4,6,8,10,12,14,16,18,20
		/// 3,6,9,12,15,18,21,24,27,30
		/// 4,8,12,16,20,24,28,32,36,40
		/// 5,10,15,20,25,30,35,40,45,50
		/// 6,12,18,24,30,36,42,48,54,60
		/// 7,14,21,28,35,42,49,56,63,70
		/// 8,16,24,32,40,48,56,64,72,80
		/// 9,18,27,36,45,54,63,72,81,90
		/// 10,20,30,40,50,60,70,80,90,100
        /// </summary>
        public void ShowHundredSquareCalc()
        {
			List<int> numList1 = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
			List<int> numList2 = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

			List<List<int>> numLists = new List<List<int>>()
			{
				numList1,numList2
			};

			//	微妙な気がする
			for (int i1 = 0; i1 < numLists[0].Count; i1++)
            {
				for (int i2 = 0; i2 < numLists[1].Count; i2++)
                {
					Console.Write(numLists[0][i1] * numLists[1][i2]);

					if (i2 < numLists[1].Count - 1)
                    {
						Console.Write(", ");
                    }
                }

				Console.WriteLine();
            }

		}
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Middle
{
    class Scores
    {
        // 생성자
        public Scores(int _Numscores)
        {
            NumScores = _Numscores;
            ScoreArr = new int[NumScores];
        }
        // 필드
        public int NumScores;
        public int[] ScoreArr;

        // 메소드
        public void Input()
        {
            Console.WriteLine("정수 정렬을 시작합니다.");
            Console.Write("> 정수 갯수 : ");
            NumScores = int.Parse(Console.ReadLine());
            ScoreArr = new int[NumScores];

            for(int index=0; index<NumScores; index++)
            {
                Console.Write("  >> {0}번 정수", index + 1);
                ScoreArr[index] = int.Parse(Console.ReadLine());
            }
        }
        public int Output()
        {
            Console.Write("정렬 결과 : ");
            for (int i = 0; i < NumScores; i++)
            {
                Console.Write(" {0}", ScoreArr[i]);
            }
            Console.ReadLine();

            return NumScores;
        }

        public void Sort(int Order)
        {
            // 배열 내(MyIndex) 앞자리에 이후 값 중
            // 최소(Order==1) 또는 최대(Order==2)
            // 배열값(KeyIndex) 찾아서 교환
            for(int MyIndex=0; MyIndex<NumScores-1; MyIndex++)
            {
                int KeyIndex = MyIndex; // 일단 내 값을 최대(소) 값이 있는 인덱스로 설정
                for(int UrIndex=MyIndex+1; UrIndex < NumScores; UrIndex++)
                {
                    // 오름차순이고(1) 현재 최소값(KeyIndex) 보다 뒤에 있는 값이(UrIndex) 작으면 교환
                    if (Order == 1 && ScoreArr[UrIndex] < ScoreArr[KeyIndex])
                        KeyIndex = UrIndex;
                    // 내림차순이고(2) 현재 최대값(KeyIndex) 보다 뒤에 있는 값이(UrIndex) 크면 교환
                    else if (Order == 2 && ScoreArr[UrIndex] > ScoreArr[KeyIndex])
                        KeyIndex = UrIndex;
                }

                if(MyIndex != KeyIndex)
                {
                    int Temp = ScoreArr[MyIndex]; // 내 값을 임시값에 저장
                    ScoreArr[MyIndex] = ScoreArr[KeyIndex]; // 내 값을 다른 변수값 지정
                    ScoreArr[KeyIndex] = Temp; // 다른 변수에 Temp에 저장되어 있는 내 값 지정
                }
            }
        }
    }
}

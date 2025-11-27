using NUnit.Framework;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class Control : MonoBehaviour
{
    public int a;
    public int b;
    public string fruit;
    public int[] art2 = new int[] { };
    public char[,] ch2 = new char[3, 3];

    void Start()
    {
        if (a > b)
        {
            Debug.Log("a 가 b 보다 큽니다.");
        }
        else if (a < b)
        {
            Debug.Log("b 가 a 보다 큽니다.");
        }
        else
        {
            Debug.Log("a 와 b 는 같습니다.");
        }

        switch (this.fruit)
        {
            case "사과":
                Debug.Log("사과는 빨갛습니다.");
                break;

            case "바나나":
                Debug.Log("바나나는 노랗습니다.");
                break;

            case "포도":
                Debug.Log("포도는 보라색입니다.");
                break;

            default:
                Debug.Log("알 수 없는 과일입니다.");
                break;
        }

        for (int i = 0; i < 5; i++)
        {
            Debug.Log("i 의 값: " + i);
        }


        while (a < 10)
        {
            Debug.Log("a 의 값: " + a);
            a++;
        }

        do
        {
            Debug.Log("b 의 값: " + b);
            b--;
        } while (b > 0);

        string[] array = new string[5];
        array[0] = "강대원";
        array[1] = "민영희";
        array[2] = "박두팔";
        array[3] = "안선생";
        array[4] = "함수빈";

        array = new string[6];
        // array 6칸 새로 만든다
        // 기존 값은 다 날아감.

        /*
         * 
         */


        // 0 ~ 4
        // array는 철저하게 자신의 영역을 가지고 있음.


        for (int i = 0; i < 5; i++)
        {
            Debug.Log(array[i]);
                }



        
        

        for (int i = 0; i < 5; i++)
        {
            Debug.Log(array[i]);
        }


        int[] score = { 90, 85, 78, 92, 88 };

        char[] charArray;
        // 칸은 나중에 만들어줘도 됨.
        // char [] charArray = new char [1];


        // 1차원 배열 - 선
        // 

        string[,] zoo = new string[3, 3];
            zoo[0, 0] = "사자";
            zoo[0, 1] = "호랑이";
        zoo[0, 2] = "표범";
            zoo[1, 0] = "코끼리";
            zoo[1, 1] = "기린";
            zoo[1, 2] = "하마";
        zoo[2, 0] = "원숭이";
            zoo[2, 1] = "침팬지";
            zoo[2, 2] = "고릴라";

        int[,] samsam = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 }, { 10, 11, 12 } };
            Debug.Log(samsam[3, 2]);


        // array 사용하는 이유: 가장 간결하고 깔끔함.
        // list는 값을 색출하기 어려움

        // 큐 스택

        List<string> studentList = new List<string>();
        studentList.Add("강대원");
        studentList.Add("민영희");
        studentList.Add(null);
        studentList.Add("안선생");
        studentList.Add("함수빈");
        studentList.Add("구경일");

       for (int k = 0; k < studentList.Count; k++)
        {
            Debug.Log("학생 이름: " + studentList[k]);
        }

        Debug.Log(studentList[3]);

        // LIST가  ㅍ


    }
}
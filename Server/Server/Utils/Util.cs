/******
공동 작성
작성일 : 23.05.15

최근 수정 일자 : 23.09.28
최근 수정 사항 : 리눅스 환경 설정 추가
******/

using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using Newtonsoft.Json;

namespace Server
{
    public class Util
    {


        /// <summary>
        /// * 필요 클래스<br/>
        /// {0} - 실제 데이터 가지고 있는 클래스<br/>
        /// {0}Handler - member로 이름이 ({0}s).ToLower() 인 List&lt;{0}&gt; 필요<br/>
        /// Data는 Json\Datas\{relativePath}.json 에 있어야함
        /// </summary>
        /// <typeparam name="Handler"> {0}Handler </typeparam>
        /// <param name="relativePath"> Json이름</param>
        /// <returns></returns>
        public static Handler ParseJson<Handler>(string relativePath)
        {
            // 현재 실행 중인 Assembly(프로그램)의 위치를 얻어옵니다.
            string currentPath = Assembly.GetExecutingAssembly().Location;

            string jsonPath;
            if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
            {
                int idx = currentPath.IndexOf("Server.dll");
                currentPath = currentPath.Substring(0, idx);
                jsonPath = Path.Combine(currentPath, $@"Json/Datas/{relativePath}.json");
                Console.WriteLine(jsonPath);
            }
            else
            {
                // 상대 경로를 사용하여 json 데이터 위치를 설정합니다.
                jsonPath = Path.Combine(Path.GetDirectoryName(currentPath), @$"../../../Json/Datas/{relativePath}.json");
            }

            // json 파일의 내용을 읽어옵니다.
            string jsonData = File.ReadAllText(jsonPath);


            // json 데이터를 파싱하여 Handler 형태로 변환합니다.
            Handler handler = JsonConvert.DeserializeObject<Handler>(jsonData);

            // 파싱된 데이터를 반환합니다.
            return handler;
        }


    }
}
﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Web;

namespace Apps.Web.Quartz.KdHelper
{
    public class TrackingMoreHelper1
    {
        // the apikey you get from trackingmore
        //a0
        //private string ApiKey = "afe910d0-68f6-4e22-8cb4-f13f91c631ba";
        //3qhi
        private string ApiKey = "c4f29f54-4f29-4d30-ba16-e30792879829";


        public string getOrderTracesByJson(string requestData, string urlStr, string method)
        {
            string result = null;
            if (method.Equals("post"))
            {
                string ReqURL = "http://api.trackingmore.com/v2/trackings/post";
                string RelUrl = ReqURL + urlStr;
                result = sendPost(ReqURL, requestData, "POST");
            }
            else if (method.Equals("get"))
            {
                string ReqURL = "http://api.trackingmore.com/v2/trackings/get";
                string RelUrl = ReqURL + urlStr;
                //Console.WriteLine("RelUrl:" + RelUrl);
                result = sendPost(RelUrl, requestData, "GET");
            }
            else if (method.Equals("batch"))
            {
                string ReqURL = "http://api.trackingmore.com/v2/trackings/batch";
                string RelUrl = ReqURL + urlStr;
                //Console.WriteLine("RelUrl:" + RelUrl);
                result = sendPost(RelUrl, requestData, "POST");
            }
            else if (method.Equals("codeNumberGet"))
            {

                string ReqURL = "http://api.trackingmore.com/v2/trackings";
                string RelUrl = ReqURL + urlStr;
                //Console.WriteLine("RelUrl:" + RelUrl);
                result = sendPost(RelUrl, requestData, "GET");
            }
            else if (method.Equals("codeNumberPut"))
            {

                string ReqURL = "http://api.trackingmore.com/v2/trackings";
                string RelUrl = ReqURL + urlStr;
                //Console.WriteLine("RelUrl:" + RelUrl);
                result = sendPost(RelUrl, requestData, "PUT");
            }
            else if (method.Equals("codeNumberDel"))
            {

                string ReqURL = "http://api.trackingmore.com/v2/trackings";
                string RelUrl = ReqURL + urlStr;
                //Console.WriteLine("RelUrl:" + RelUrl);
                result = sendPost(RelUrl, requestData, "DELETE");
            }

            else if (method.Equals("realtime"))
            {

                string ReqURL = "http://api.trackingmore.com/v2/trackings/realtime";
                string RelUrl = ReqURL + urlStr;
                //Console.WriteLine("RelUrl:" + RelUrl);
                result = sendPost(RelUrl, requestData, "POST");
            }

            return result;



        }


        private string sendPost(string url, string requestData, string method)
        {
            string result = "";
            byte[] byteData = null;
            if (requestData != null)
            {
                byteData = Encoding.GetEncoding("UTF-8").GetBytes(requestData.ToString());
            }

            //try
            //{

                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                request.ContentType = "application/x-www-form-urlencoded";
                request.Timeout = 30 * 1000;
                request.Method = method;
                request.Headers["Trackingmore-Api-Key"] = ApiKey;

                if (byteData != null)
                {
                    Stream stream = request.GetRequestStream();
                    stream.Write(byteData, 0, byteData.Length);
                    stream.Flush();
                    stream.Close();
                }


                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                Stream backStream = response.GetResponseStream();
                StreamReader sr = new StreamReader(backStream, Encoding.GetEncoding("UTF-8"));
                result = sr.ReadToEnd();
                sr.Close();
                backStream.Close();
                response.Close();
                request.Abort();
            //}
            //catch (Exception ex)
            //{
            //    result = ex.Message;
            //}
            return result;
        }
    }
}
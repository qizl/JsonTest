using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace JsonTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var users = new List<User>();
            for (int a = 0; a < 100000; a++)
            {
                User user = new User();
                user.Address = "我是地址";
                user.Contacter = "我是紧急联系人";
                user.ContactPhone = "我是紧急联系人联系方式";
                user.EdiTime = DateTime.Now;
                user.Email = "我是邮箱";
                user.HeadThumbUrl = "我是头像缩略图路径";
                user.HeadUrl = "我是头像路径";
                user.ID = a;
                user.IdCard = "我是身份证";
                user.LoginId = "我是登录账号";
                user.NFCID = "我是NFCID";
                user.Note = "我是备注";
                user.Number = "我是编号";
                user.Password = "我是密码";
                user.Phone = "我是手机号";
                user.ReTime = DateTime.Now;
                user.RFID = "我是RFID";
                user.Role = 1;
                users.Add(user);
            }
            DateTime begin;

            begin = DateTime.Now;
            JsonConvert.SerializeObject(users);
            Console.WriteLine($"json.net序列化时间：{(DateTime.Now - begin).TotalSeconds}s");

            begin = DateTime.Now;
            fastJSON.JSON.ToNiceJSON(users);
            Console.WriteLine($"fastjson序列化时间：{(DateTime.Now - begin).TotalSeconds}s");
            Console.Read();
        }
    }
}

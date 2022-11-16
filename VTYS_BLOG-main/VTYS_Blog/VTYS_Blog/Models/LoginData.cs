using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FireSharp;
using FireSharp.Response;
using FireSharp.Config;
using FireSharp.Interfaces;
using Newtonsoft.Json;



namespace VTYS_Blog.Models
{
    public class LoginData
    {
        public static IFirebaseConfig fc = new FirebaseConfig()
        {
            AuthSecret = "FG14qLcvzKH2pvA753I3t2NR9B2fImYjIxz1t2Ki",
            BasePath = "https://blogsayfasi-e8b92-default-rtdb.firebaseio.com/"
        };

        public IFirebaseClient client = new FireSharp.FirebaseClient(fc);

        public static void Kayıtol()
        {
           
        }

    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public static class General
    {
        public static class ProcessType
        {
            public static int Login = 1;
            public static int AddressAdd = 2;
            public static int AddressUpdate = 3;
            public static int AddressDelete = 4;
            public static int AdsAdd = 5;
            public static int AdsUpdate = 6;
            public static int AdsDelete = 7;
            
            
            public static int UserAdd = 8;
            public static int UserUpdate = 9;
            public static int UserDelete = 10;
            public static int VideoAdd = 11;
            public static int VideoUpdate = 12;
            public static int VideoDelete = 13;
            public static int CarAdd = 14;
            public static int CarUpdate = 15;
            public static int CarDelete = 16;
            public static int ImageAdd = 17;
            public static int ImageUpdate = 18;
            public static int ImageDelete = 19;
            public static int TagAdd = 20;
            public static int TagUpdate = 21;
            public static int TagDelete = 22;
            public static int CommentApprove = 23;
            public static int CommentDelete = 24;
            public static int MessageRead = 25;
            public static int MessageDelete = 26;

        }
        public static class TableName
        {
            public static string login = "login";
            public static string Addess = "Address";
            public static string Ads = "Ads";
           
            public static string User = "User";
            public static string Video = "Video";
            public static string Car = "Car";
            public static string Image = "Image";
            public static string Tag = "Tag";
            public static string Comment = "Comment";
            public static string Contact = "Contact";

        }

        public static class Messages
        {
            public static int AddSuccess = 1;
            public static int EmptyArea = 2;
            public static int UpdateSuccess = 3;
            public static int ImageMissing = 4;
            public static int ExtensionError = 5;
            public static int GeneralError = 6;

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumWD.BO
{
    class PostGenerator
    {
        public static object[] ValidPost = new object[]
        {
            new Post("Test", "http://localhost:3030/admin", "Test testing."                   ).GetObject(),
            new Post("Test2", "https://www.w3schools.com/xml/xpath_axes.asp", "Tsdfsdfsdfsdf.").GetObject(),
            new Post("Test3", "https://stackoverflow.com/", "123345467890"                    ).GetObject(),
            new Post("Test4", "https://stackoverflow.com/", "fuuuuuuuu!@#$%^&*()."            ).GetObject(),
            new Post("Test5", "ert", "ad"                                                     ).GetObject(),
            new Post("Test5", "qweqwe", "ad"                                                  ).GetObject(),
            new Post("Test6", "ertert", "werer testing."                                      ).GetObject(),
            new Post("Test7", "werwe/", "sdfsdfsdfsdfsdfsdfsdfadfqwe4rqwefasdfest testing."   ).GetObject(),
            new Post("Test7", "werwerw/", "rwerwehvb testing."                                ).GetObject(),
            new Post("12345", "werwesdfrw/", "rwehvb testing."                                ).GetObject(),
            new Post("!@#$%^&*()", "w", "rwehvb testing."                                     ).GetObject(),
            new Post("Test8345555533333333333333333334534", "q", "werer testing."             ).GetObject()
        };
    }
}

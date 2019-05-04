using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumWD
{
    public static class DataSource
    {
        public static object[] DataTest = new object[]
        {
            new object[] {"Test", "http://localhost:3030/admin", "Test testing."},
            new object[] { "Test2", "https://www.w3schools.com/xml/xpath_axes.asp", "Tsdfsdfsdfsdf."      },
            new object[] { "Test3", "https://stackoverflow.com/", "123345467890"                          },
            new object[] { "Test4", "https://stackoverflow.com/", "fuuuuuuuu!@#$%^&*()."                  },
            new object[] { "Test5", "ert", "ad"                                                           },
            new object[] { "Test5", "qweqwe", "ad"                                                        },
            new object[] { "Test6", "ertert", "werer testing."                                            },
            new object[] { "Test7", "werwe/", "sdfsdfsdfsdfsdfsdfsdfadfqwe4rqwefasdfest testing."         },
            new object[] { "Test7", "werwerw/", "rwerwehvb testing."                                      },
            new object[] { "12345", "werwesdfrw/", "rwehvb testing."                                      },
            new object[] { "!@#$%^&*()", "w", "rwehvb testing."                                           },
            new object[] { "Test8345555533333333333333333334534", "q", "werer testing." }
        };

    }
}
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tiles_APP
{
    internal class Tiles_APP_Shared_Content
    {
        System.Data.SqlClient.SqlConnection Con = new System.Data.SqlClient .SqlConnection(@"");

         void Con_Open()
        {
            if(Con.State==ConnectionState.Closed)
            {
                Con.Open();
            }
        
        }

         void Con_Close()
        {
            if(Con.State==ConnectionState.Open)
            {
                Con.Close();
            }
        }

        public static int Auto_Incr()
        {
            
            return 0;

        }

        

        
    }

}

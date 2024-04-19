using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace active_way
{
    public class ImageLoader
    {
        Conection conection = new Conection();
        public string LoadImage()
        {
            conection.openConnection();
            string query = $"SELECT Avatar FROM [User] WHERE ID_User = @UserId";

            using (SqlCommand command = conection.commandConection(query))
            {
                string userId = UserManager.GetUserId();
                command.Parameters.AddWithValue("@UserId", userId);
                object result = command.ExecuteScalar();
                conection.closeConnection();

                if (result != null && result != DBNull.Value) // Добавленная проверка
                {
                    string imagePath = (string)result;
                    if (!string.IsNullOrEmpty(imagePath))
                    {
                        return imagePath;
                    }
                }

                return null;
            }
        }

        }
   }



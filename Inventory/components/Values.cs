using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.components
{
    class Values
    {
        Connection connection = new Connection();

        public static string server_address = "127.0.0.1";
        public static string server_port = "3305";
        public static string server_username = "superzonik";
        public static string server_password = "4735489";
        
        //<Authorization token to authorize admin transactions>
        public static int authorization_token;
        
        public int AuthorizationToken
        {
            get { return authorization_token; }
            set { authorization_token = value; }
        }

        public int UserID
        {
            get { return userd_id; }
            set { userd_id = value; }
        }

        //</Authorization token to authorize admin transactions>

        //<PUBLIC TRANSACTION DETAILS>
        public static string transaction_id;

        public string TransactionID
        {
            get { return transaction_id; }
            set { transaction_id = value; }
        }

        //<PUBLIC CART ITEM DETAILS>
        public static int cart_item_id;
        public static string cart_item_description;
        public static string cart_item_serialnumber;
        public static double cart_item_price;
        public static double cart_grand_total;

        public int CartItemID
        {
            get { return cart_item_id; }
            set { cart_item_id = value; }
        }

        public string CartItemDescription
        {
            get { return cart_item_description; }
            set { cart_item_description = value; }
        }

        public string CartItemSerialNumber
        {
            get { return cart_item_serialnumber; }
            set { cart_item_serialnumber = value; }
        }

        public double CartItemPrice
        {
            get { return cart_item_price; }
            set { cart_item_price = value; }
        }

        public double CartGrandTotal
        {
            get { return cart_grand_total; }
            set { cart_grand_total = value; }
        }

        //</PUBLIC CART ITEM DETAILS>


        //<USER DATA>
        public static int user_admin = 1;
        public static int userd_id = 1;
        public static int user_level;
        public static string username;
        public static string user_password;
        public static bool user_active;

        public string UserName
        {
            get { return username; }
            set { username = value; }
        }

        public string UserPassword
        {
            get { return user_password; }
            set { user_password = value; }
        }

        public int UserLevel
        {
            get { return user_level; }
            set { user_level = value; }
        }

        public bool UserActive
        {
            get { return user_active; }
            set { user_active = value; }
        }

        public string UserStatus
        {
            get
            {
                if (user_active == true)
                {
                    return "Active";
                }
                else
                {
                    return "Inactive";
                }

            }
        }

        //</USER DATA>

        // </summary>
    }
}

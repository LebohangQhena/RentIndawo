﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace indawo
{
    public class userposts
    {
        public string user_id { get; set; }
        public string location_id { get; set; }
        public string apartment_id { get; set; }
        public string apartment_price { get; set; }
        public string apartment_availiability { get; set; }
        public string apartment_dateposted { get; set; }
        public string apartment_type { get; set; }
        public string apartment_details { get; set; }
        public string apartment_picture { get; set; }
        public string apartment_views { get; set; }

        public userposts(string apartment_id, string user_id, string location_id, string apartment_price, string apartment_availiability, string apartment_dateposted, string apartment_type, string apartment_details, string apartment_picture, string apartment_views)
        {
            this.user_id = user_id;
            this.location_id = location_id;
            this.apartment_id = apartment_id;
            this.apartment_price = apartment_price;
            this.apartment_availiability = apartment_availiability;
            this.apartment_dateposted = apartment_dateposted;
            this.apartment_type = apartment_type;
            this.apartment_details = apartment_details;
            this.apartment_picture = apartment_picture;
            this.apartment_views = apartment_views;
        }
    }
}
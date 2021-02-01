using System;

namespace OnlinePortfolioZB.Emails
{
    //   _____         _                               _             
    //  |_   _|       | |                             | |  (_)            
    //    | |    __ _ | | __  ___        _ __    ___  | |_  _   ___   ___ 
    //    | |   / _` || |/ / / _ \      | '_ \  / _ \ | __|| | / __| / _ \
    //    | |  | (_| ||   < |  __/      | | | || (_) || |_ | || (__ |  __/
    //    \_/   \__,_||_|\_\ \___|      |_| |_| \___/  \__||_| \___| \___|

    // ZB - Seems like using underscores to separate variables is the way to go here.
    // Otherwise it looks like setting up configuration in Startup.cs 
    // does not clearly distinguish between variables even if they do have very different names

    // * copied from ENR Management

    public class EmailSettings
    {
        public String SENDGRID_API_KEY { get; set; }

        public String Sender_Name { get; set; }

        public String From_Email { get; set; }
    }
}

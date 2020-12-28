using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving
{
    /// <summary>
    /// Input: myemail@address.com
    /// Output: m**** il@*******.com
    /// </summary>
    class MaskingEmail
    {
        // v****u@gmail.com
        private string MaskedEmail1(string email)
        {
            var maskedEmail = String.Format("{0}****{1}", email[0],
            email.Substring(email.IndexOf('@') - 1));

            return maskedEmail;
        }

        // v*************hu@*****.com
        private string MaskedEmail2(string email)
        {     
            var emailsplit = email.Split('@');
            var newsplit = emailsplit[1].Split('.');
            char[] array1 = emailsplit[0].ToCharArray();
            char[] array2 = newsplit[0].ToCharArray();
            var output = "";

            for (int i = 0; i < array1.Length; i++)
            {
                if (array1.Length > 4)
                {
                    if (i == 0 || i == array1.Length - 1 || i == array1.Length - 2)
                    {
                        output += array1[i];
                    }
                    else
                    {
                        output += "*";
                    }
                }
                else
                {
                    if (i == 0)
                    {
                        output += array1[i];
                    }
                    else
                    {
                        output += "*";
                    }
                }
            }
            output += "@";
            for (int i = 0; i < array2.Length; i++) output += "*";
            for (int i = 1; i < newsplit.Length; i++) output += "." + newsplit[i];

            return output;
        }

        //static void Main(string[] args)
        //{
        //    MaskingEmail maskingEmail = new MaskingEmail();
        //    var email = maskingEmail.MaskedEmail1("venkateshchunchu@gmail.com");
        //    Console.WriteLine("Masked Email is: {0}", email);
        //    email = maskingEmail.MaskedEmail2("venkateshchunchu@gmail.com");
        //    Console.WriteLine("Masked Email is: {0}", email);
        //    Console.ReadLine();
        //}
    }
}

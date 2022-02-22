// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary>
    /// Contact information for domain registration. If &apos;Domain Privacy&apos; option is not selected then the contact information is made publicly available through the Whois 
    /// directories as per ICANN requirements.
    /// </summary>
    public partial class ContactInformation
    {
        /// <summary> Initializes a new instance of ContactInformation. </summary>
        /// <param name="email"> Email address. </param>
        /// <param name="nameFirst"> First name. </param>
        /// <param name="nameLast"> Last name. </param>
        /// <param name="phone"> Phone number. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="email"/>, <paramref name="nameFirst"/>, <paramref name="nameLast"/> or <paramref name="phone"/> is null. </exception>
        public ContactInformation(string email, string nameFirst, string nameLast, string phone)
        {
            if (email == null)
            {
                throw new ArgumentNullException(nameof(email));
            }
            if (nameFirst == null)
            {
                throw new ArgumentNullException(nameof(nameFirst));
            }
            if (nameLast == null)
            {
                throw new ArgumentNullException(nameof(nameLast));
            }
            if (phone == null)
            {
                throw new ArgumentNullException(nameof(phone));
            }

            Email = email;
            NameFirst = nameFirst;
            NameLast = nameLast;
            Phone = phone;
        }

        /// <summary> Initializes a new instance of ContactInformation. </summary>
        /// <param name="addressMailing"> Mailing address. </param>
        /// <param name="email"> Email address. </param>
        /// <param name="fax"> Fax number. </param>
        /// <param name="jobTitle"> Job title. </param>
        /// <param name="nameFirst"> First name. </param>
        /// <param name="nameLast"> Last name. </param>
        /// <param name="nameMiddle"> Middle name. </param>
        /// <param name="organization"> Organization contact belongs to. </param>
        /// <param name="phone"> Phone number. </param>
        internal ContactInformation(Address addressMailing, string email, string fax, string jobTitle, string nameFirst, string nameLast, string nameMiddle, string organization, string phone)
        {
            AddressMailing = addressMailing;
            Email = email;
            Fax = fax;
            JobTitle = jobTitle;
            NameFirst = nameFirst;
            NameLast = nameLast;
            NameMiddle = nameMiddle;
            Organization = organization;
            Phone = phone;
        }

        /// <summary> Mailing address. </summary>
        public Address AddressMailing { get; set; }
        /// <summary> Email address. </summary>
        public string Email { get; set; }
        /// <summary> Fax number. </summary>
        public string Fax { get; set; }
        /// <summary> Job title. </summary>
        public string JobTitle { get; set; }
        /// <summary> First name. </summary>
        public string NameFirst { get; set; }
        /// <summary> Last name. </summary>
        public string NameLast { get; set; }
        /// <summary> Middle name. </summary>
        public string NameMiddle { get; set; }
        /// <summary> Organization contact belongs to. </summary>
        public string Organization { get; set; }
        /// <summary> Phone number. </summary>
        public string Phone { get; set; }
    }
}

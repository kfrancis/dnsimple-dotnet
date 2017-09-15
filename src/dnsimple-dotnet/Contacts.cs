using dnsimple_dotnet.Response;
using System;
using System.Collections.Generic;
using System.Text;

namespace dnsimple_dotnet
{
    /// <summary>
    /// Provides access to the DNSimple Contacts API.
    /// </summary>
    /// <remarks>https://developer.dnsimple.com/v2/contacts</remarks>
    public interface Contacts
    {
        /// <summary>
        /// Lists the contacts in the account.
        /// </summary>
        /// <param name="accountId">The account ID</param>
        /// <returns>The list contacts resposne</returns>
        /// <remarks>https://developer.dnsimple.com/v2/contacts/#list</remarks>
        ListContactsResponse ListContacts(string accountId);

        /// <summary>
        /// Lists the contacts in the account.
        /// </summary>
        /// <param name="accountId">The account ID</param>
        /// <param name="options">Options to pass to the contacts API</param>
        /// <returns>The list contacts response</returns>
        /// <remarks>https://developer.dnsimple.com/v2/contacts/#list</remarks>
        ListContactsResponse ListContacts(string accountId, Dictionary<string, string> options);

        /// <summary>
        /// Get a specific contact associated to an account using the contacts's ID.
        /// </summary>
        /// <param name="accountId">The account ID</param>
        /// <param name="contactId">The contact ID</param>
        /// <returns>The get contact response</returns>
        /// <remarks>https://developer.dnsimple.com/v2/contacts/#get</remarks>
        GetContactResponse GetContact(string accountId, string contactId);

        /// <summary>
        /// Create a contact in the account.
        /// </summary>
        /// <param name="accountId">The account ID</param>
        /// <param name="attributes">The attributes to construct the contact</param>
        /// <returns>The create contact response</returns>
        /// <remarks>https://developer.dnsimple.com/v2/contacts/#create</remarks>
        CreateContactResponse CreateContact(string accountId, Dictionary<string, string> attributes);

        /// <summary>
        /// Update a contact in the account.
        /// </summary>
        /// <param name="accountId">The account ID</param>
        /// <param name="contactId">The contact ID</param>
        /// <param name="attributes">The attributes to updatee the contact</param>
        /// <returns>The update contact response</returns>
        /// <remarks>https://developer.dnsimple.com/v2/contacts/#update</remarks>
        UpdateContactResponse UpdateContact(string accountId, string contactId, Dictionary<string, string> attributes);

        /// <summary>
        /// Delete a contact from the account.
        /// </summary>
        /// <param name="accountId">The account ID</param>
        /// <param name="contactId">The contact ID</param>
        /// <returns>The delete contact response</returns>
        /// <remarks>https://developer.dnsimple.com/v2/contacts/#delete</remarks>
        DeleteContactResponse DeleteContact(string accountId, string contactId);
    }
}

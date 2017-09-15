using dnsimple_dotnet.Response;
using System;
using System.Collections.Generic;
using System.Text;

namespace dnsimple_dotnet
{
    /// <summary>
    /// Provides access to the DNSimple Zones API.
    /// </summary>
    /// <remarks>https://developer.dnsimple.com/v2/zones</remarks>
    public interface Zones
    {
        /// <summary>
        /// Lists the zones in the account.
        /// </summary>
        /// <param name="accountId">The account ID</param>
        /// <returns>The list zones response</returns>
        /// <remarks>https://developer.dnsimple.com/v2/zones/#list</remarks>
        ListZonesResponse ListZones(string accountId);

        /// <summary>
        /// Lists the zones in the account.
        /// </summary>
        /// <param name="accountId">The account ID</param>
        /// <param name="options">The options to pass to the zones API</param>
        /// <returns>The list zones response</returns>
        /// <remarks>https://developer.dnsimple.com/v2/zones/#list</remarks>
        ListZonesResponse ListZones(string accountId, Dictionary<string, string> options);

        /// <summary>
        /// Get a specific zone associated to an account using the zone's name or ID.
        /// </summary>
        /// <param name="accountId">The account ID</param>
        /// <param name="zoneId">The zone name or ID</param>
        /// <returns>The get zone response</returns>
        /// <remarks>https://developer.dnsimple.com/v2/zones/#get</remarks>
        GetZoneResponse GetZone(string accountId, string zoneId);

        /// <summary>
        /// Get the zone file associated to an account using the zone's name or ID.
        /// </summary>
        /// <param name="accountId">The account ID</param>
        /// <param name="zoneId">The zone name or ID</param>
        /// <returns>The get zone file response</returns>
        /// <remarks>https://developer.dnsimple.com/v2/zones/#get-file</remarks>
        GetZoneFileResponse GetZoneFile(string accountId, string zoneId);

        /// <summary>
        /// Lists the records in the zone.
        /// </summary>
        /// <param name="accountId">The account ID</param>
        /// <param name="zoneId">The zone name or ID</param>
        /// <returns>The list zone records response</returns>
        /// <remarks>https://developer.dnsimple.com/v2/zones/records/#list</remarks>
        ListZoneRecordsResponse ListZoneRecords(string accountId, string zoneId);

        /// <summary>
        /// Lists the records in the zone.
        /// </summary>
        /// <param name="accountId">The account ID</param>
        /// <param name="zoneId">The zone name or ID</param>
        /// <param name="options">The options to pass to the zones API</param>
        /// <returns>The list zone records response</returns>
        /// <remarks>https://developer.dnsimple.com/v2/zones/records/#list</remarks>
        ListZoneRecordsResponse ListZoneRecords(string accountId, string zoneId, Dictionary<string, string> options);

        /// <summary>
        /// Get a specific record associated to a zone using the zone's name or ID
        /// </summary>
        /// <param name="accountId">The account ID</param>
        /// <param name="zoneId">The zone name or ID</param>
        /// <param name="recordId">The record ID</param>
        /// <returns>The get zone record response</returns>
        /// <remarks>https://developer.dnsimple.com/v2/zones/records/#get</remarks>
        GetZoneRecordResponse GetZoneRecord(string accountId, string zoneId, string recordId);

        /// <summary>
        /// Create a record in a zone.
        /// </summary>
        /// <param name="accountId">The account ID</param>
        /// <param name="zoneId">The zone ID</param>
        /// <param name="attributes">The zone attributes</param>
        /// <returns>The create zone record response</returns>
        /// <remarks>https://developer.dnsimple.com/v2/zones/records/#create</remarks>
        CreateZoneRecordResponse CreateZoneRecord(string accountId, string zoneId, Dictionary<string, object> attributes);

        /// <summary>
        /// Update a record in a zone.
        /// </summary>
        /// <param name="accountId">The account ID</param>
        /// <param name="zoneId">The zone ID</param>
        /// <param name="recordId">The record ID</param>
        /// <param name="attributes">The zone attributes</param>
        /// <returns>The update zone record response</returns>
        /// <remarks>https://developer.dnsimple.com/v2/zones/records/#update</remarks>
        UpdateZoneRecordResponse UpdateZoneRecord(string accountId, string zoneId, string recordId, Dictionary<string, object> attributes);

        /// <summary>
        /// Delete a record from a zone.
        /// </summary>
        /// <param name="accountId">The account ID</param>
        /// <param name="zoneId">The zone ID</param>
        /// <param name="recordId">The record ID</param>
        /// <returns>The delete zone record response</returns>
        /// <remarks>https://developer.dnsimple.com/v2/zones/records/#delete</remarks>
        DeleteZoneRecordResponse DeleteZoneRecord(string accountId, string zoneId, string recordId);
    }
}

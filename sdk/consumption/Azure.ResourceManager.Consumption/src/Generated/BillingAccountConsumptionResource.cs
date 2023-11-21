// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Autorest.CSharp.Core;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Consumption.Models;

namespace Azure.ResourceManager.Consumption
{
    /// <summary>
    /// A class extending from the BillingAccountResource in Azure.ResourceManager.Consumption along with the instance operations that can be performed on it.
    /// You can only construct a <see cref="BillingAccountConsumptionResource"/> from a <see cref="ResourceIdentifier"/> with a resource type of Microsoft.Billing/billingAccounts.
    /// </summary>
    public partial class BillingAccountConsumptionResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="BillingAccountConsumptionResource"/> instance. </summary>
        /// <param name="billingAccountId"> The billingAccountId. </param>
        internal static ResourceIdentifier CreateResourceIdentifier(string billingAccountId)
        {
            var resourceId = $"/providers/Microsoft.Billing/billingAccounts/{billingAccountId}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _balancesClientDiagnostics;
        private readonly BalancesRestOperations _balancesRestClient;
        private readonly ClientDiagnostics _reservationTransactionsClientDiagnostics;
        private readonly ReservationTransactionsRestOperations _reservationTransactionsRestClient;
        private readonly ClientDiagnostics _eventsClientDiagnostics;
        private readonly EventsRestOperations _eventsRestClient;
        private readonly ClientDiagnostics _lotsClientDiagnostics;
        private readonly LotsRestOperations _lotsRestClient;

        /// <summary> Initializes a new instance of the <see cref="BillingAccountConsumptionResource"/> class for mocking. </summary>
        protected BillingAccountConsumptionResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="BillingAccountConsumptionResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal BillingAccountConsumptionResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _balancesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Consumption", ProviderConstants.DefaultProviderNamespace, Diagnostics);
            _balancesRestClient = new BalancesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint);
            _reservationTransactionsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Consumption", ProviderConstants.DefaultProviderNamespace, Diagnostics);
            _reservationTransactionsRestClient = new ReservationTransactionsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint);
            _eventsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Consumption", ProviderConstants.DefaultProviderNamespace, Diagnostics);
            _eventsRestClient = new EventsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint);
            _lotsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Consumption", ProviderConstants.DefaultProviderNamespace, Diagnostics);
            _lotsRestClient = new LotsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Billing/billingAccounts";

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceType), nameof(id));
        }

        /// <summary>
        /// Gets the balances for a scope by billingAccountId. Balances are available via this API only for May 1, 2014 or later.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Billing/billingAccounts/{billingAccountId}/providers/Microsoft.Consumption/balances</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Balances_GetByBillingAccount</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<ConsumptionBalanceResult>> GetBalanceAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _balancesClientDiagnostics.CreateScope("BillingAccountConsumptionResource.GetBalance");
            scope.Start();
            try
            {
                var response = await _balancesRestClient.GetByBillingAccountAsync(Id.Name, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the balances for a scope by billingAccountId. Balances are available via this API only for May 1, 2014 or later.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Billing/billingAccounts/{billingAccountId}/providers/Microsoft.Consumption/balances</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Balances_GetByBillingAccount</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ConsumptionBalanceResult> GetBalance(CancellationToken cancellationToken = default)
        {
            using var scope = _balancesClientDiagnostics.CreateScope("BillingAccountConsumptionResource.GetBalance");
            scope.Start();
            try
            {
                var response = _balancesRestClient.GetByBillingAccount(Id.Name, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List of transactions for reserved instances on billing account scope. Note: The refund transactions are posted along with its purchase transaction (i.e. in the purchase billing month). For example, The refund is requested in May 2021. This refund transaction will have event date as May 2021 but the billing month as April 2020 when the reservation purchase was made.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Billing/billingAccounts/{billingAccountId}/providers/Microsoft.Consumption/reservationTransactions</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ReservationTransactions_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="filter"> Filter reservation transactions by date range. The properties/EventDate for start date and end date. The filter supports 'le' and  'ge'. Note: API returns data for the entire start date's and end date's billing month. For example, filter properties/eventDate+ge+2020-01-01+AND+properties/eventDate+le+2020-12-29 will include data for the entire December 2020 month (i.e. will contain records for dates December 30 and 31). </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ConsumptionReservationTransaction"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ConsumptionReservationTransaction> GetReservationTransactionsAsync(string filter = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _reservationTransactionsRestClient.CreateListRequest(Id.Name, filter);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _reservationTransactionsRestClient.CreateListNextPageRequest(nextLink, Id.Name, filter);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, ConsumptionReservationTransaction.DeserializeConsumptionReservationTransaction, _reservationTransactionsClientDiagnostics, Pipeline, "BillingAccountConsumptionResource.GetReservationTransactions", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// List of transactions for reserved instances on billing account scope. Note: The refund transactions are posted along with its purchase transaction (i.e. in the purchase billing month). For example, The refund is requested in May 2021. This refund transaction will have event date as May 2021 but the billing month as April 2020 when the reservation purchase was made.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Billing/billingAccounts/{billingAccountId}/providers/Microsoft.Consumption/reservationTransactions</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ReservationTransactions_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="filter"> Filter reservation transactions by date range. The properties/EventDate for start date and end date. The filter supports 'le' and  'ge'. Note: API returns data for the entire start date's and end date's billing month. For example, filter properties/eventDate+ge+2020-01-01+AND+properties/eventDate+le+2020-12-29 will include data for the entire December 2020 month (i.e. will contain records for dates December 30 and 31). </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ConsumptionReservationTransaction"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ConsumptionReservationTransaction> GetReservationTransactions(string filter = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _reservationTransactionsRestClient.CreateListRequest(Id.Name, filter);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _reservationTransactionsRestClient.CreateListNextPageRequest(nextLink, Id.Name, filter);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, ConsumptionReservationTransaction.DeserializeConsumptionReservationTransaction, _reservationTransactionsClientDiagnostics, Pipeline, "BillingAccountConsumptionResource.GetReservationTransactions", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists the events that decrements Azure credits or Microsoft Azure consumption commitment for a billing account or a billing profile for a given start and end date.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Billing/billingAccounts/{billingAccountId}/providers/Microsoft.Consumption/events</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Events_ListByBillingAccount</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="filter"> May be used to filter the events by lotId, lotSource etc. The filter supports 'eq', 'lt', 'gt', 'le', 'ge', and 'and'. It does not currently support 'ne', 'or', or 'not'. Tag filter is a key value pair string where key and value is separated by a colon (:). </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ConsumptionEventSummary"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ConsumptionEventSummary> GetEventsAsync(string filter = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _eventsRestClient.CreateListByBillingAccountRequest(Id.Name, filter);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _eventsRestClient.CreateListByBillingAccountNextPageRequest(nextLink, Id.Name, filter);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, ConsumptionEventSummary.DeserializeConsumptionEventSummary, _eventsClientDiagnostics, Pipeline, "BillingAccountConsumptionResource.GetEvents", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists the events that decrements Azure credits or Microsoft Azure consumption commitment for a billing account or a billing profile for a given start and end date.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Billing/billingAccounts/{billingAccountId}/providers/Microsoft.Consumption/events</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Events_ListByBillingAccount</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="filter"> May be used to filter the events by lotId, lotSource etc. The filter supports 'eq', 'lt', 'gt', 'le', 'ge', and 'and'. It does not currently support 'ne', 'or', or 'not'. Tag filter is a key value pair string where key and value is separated by a colon (:). </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ConsumptionEventSummary"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ConsumptionEventSummary> GetEvents(string filter = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _eventsRestClient.CreateListByBillingAccountRequest(Id.Name, filter);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _eventsRestClient.CreateListByBillingAccountNextPageRequest(nextLink, Id.Name, filter);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, ConsumptionEventSummary.DeserializeConsumptionEventSummary, _eventsClientDiagnostics, Pipeline, "BillingAccountConsumptionResource.GetEvents", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists all Microsoft Azure consumption commitments for a billing account. The API is only supported for Microsoft Customer Agreements (MCA) and Direct Enterprise Agreement (EA)  billing accounts.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Billing/billingAccounts/{billingAccountId}/providers/Microsoft.Consumption/lots</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Lots_ListByBillingAccount</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="filter"> May be used to filter the lots by Status, Source etc. The filter supports 'eq', 'lt', 'gt', 'le', 'ge', and 'and'. It does not currently support 'ne', 'or', or 'not'. Tag filter is a key value pair string where key and value is separated by a colon (:). </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ConsumptionLotSummary"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ConsumptionLotSummary> GetLotsAsync(string filter = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _lotsRestClient.CreateListByBillingAccountRequest(Id.Name, filter);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _lotsRestClient.CreateListByBillingAccountNextPageRequest(nextLink, Id.Name, filter);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, ConsumptionLotSummary.DeserializeConsumptionLotSummary, _lotsClientDiagnostics, Pipeline, "BillingAccountConsumptionResource.GetLots", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists all Microsoft Azure consumption commitments for a billing account. The API is only supported for Microsoft Customer Agreements (MCA) and Direct Enterprise Agreement (EA)  billing accounts.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Billing/billingAccounts/{billingAccountId}/providers/Microsoft.Consumption/lots</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Lots_ListByBillingAccount</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="filter"> May be used to filter the lots by Status, Source etc. The filter supports 'eq', 'lt', 'gt', 'le', 'ge', and 'and'. It does not currently support 'ne', 'or', or 'not'. Tag filter is a key value pair string where key and value is separated by a colon (:). </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ConsumptionLotSummary"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ConsumptionLotSummary> GetLots(string filter = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _lotsRestClient.CreateListByBillingAccountRequest(Id.Name, filter);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _lotsRestClient.CreateListByBillingAccountNextPageRequest(nextLink, Id.Name, filter);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, ConsumptionLotSummary.DeserializeConsumptionLotSummary, _lotsClientDiagnostics, Pipeline, "BillingAccountConsumptionResource.GetLots", "value", "nextLink", cancellationToken);
        }
    }
}

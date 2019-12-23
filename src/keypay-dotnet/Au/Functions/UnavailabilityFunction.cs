using System;
using System.Collections.Generic;
using System.Linq;
using RestSharp;
using KeyPayV2.Common;
using KeyPayV2.Common.Models;
using KeyPayV2.Au.Enums;
using KeyPayV2.Au.Models.Common;
using KeyPayV2.Au.Models.Unavailability;

namespace KeyPayV2.Au.Functions
{
    public class UnavailabilityFunction : BaseFunction
    {
        public UnavailabilityFunction(ApiRequestExecutor api) : base(api) {}

        /// <summary>
        /// List Unavailabilities
        /// </summary>
        /// <remarks>
        /// Lists all of the unavailabilities for this business, with optional filters.
        /// </remarks>
        public List<UnavailabilityModel> ListUnavailabilities(int businessId, ListUnavailabilitiesQueryModel request)
        {
            return ApiRequest<List<UnavailabilityModel>>($"/business/{businessId}/unavailability?fromDate={request.FromDate}&toDate={request.ToDate}&employeeId={request.EmployeeId}&defaultLocationId={request.DefaultLocationId}");
        }

        /// <summary>
        /// Create Unavailability
        /// </summary>
        /// <remarks>
        /// Creates a new unavailability for the employee.
        /// </remarks>
        public UnavailabilityModel CreateUnavailability(int businessId, UnavailabilityModel unavailabilityModel)
        {
            return ApiRequest<UnavailabilityModel,UnavailabilityModel>($"/business/{businessId}/unavailability", unavailabilityModel, Method.POST);
        }

        /// <summary>
        /// Get unavailability by ID
        /// </summary>
        /// <remarks>
        /// Gets the unavailability with the specified ID.
        /// </remarks>
        public UnavailabilityModel GetUnavailabilityById(int businessId, int id)
        {
            return ApiRequest<UnavailabilityModel>($"/business/{businessId}/unavailability/{id}");
        }

        /// <summary>
        /// Update Unavailability
        /// </summary>
        /// <remarks>
        /// Updates the unavailability with the specified ID.
        /// </remarks>
        public void UpdateUnavailability(int businessId, int id, UnavailabilityModel unavailabilityModel)
        {
            ApiRequest($"/business/{businessId}/unavailability/{id}", unavailabilityModel, Method.PUT);
        }

        /// <summary>
        /// Delete Unavailability
        /// </summary>
        /// <remarks>
        /// Deletes the unavailability with the specified ID.
        /// </remarks>
        public void DeleteUnavailability(int businessId, int id)
        {
            ApiRequest($"/business/{businessId}/unavailability/{id}", Method.DELETE);
        }
    }
}

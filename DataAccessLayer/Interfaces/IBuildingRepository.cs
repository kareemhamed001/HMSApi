﻿using SharedClasses;
using SharedClasses.Responses;

namespace DataAccessLayer.Interfaces
{
    public interface IBuildingRepository
    {
        Task<IEnumerable<BuildingResponse>> GetAllBuildingsAsync(int page, int PerPage);
        Task<BuildingResponse?> GetBuildingById(int id);
        Task<BuildingResponse> CreateBuildingAsync(Building building);
        Task<BuildingResponse> UpdateBuildingAsync(Building building);
        Task<Building> DeleteBuildingAsync(Building building);

        // Additional methods
        Task<IEnumerable<FloorResponse>> GetFloorsByBuildingId(int buildingId);
        Task<Building> BuildingExist(int id);
    }
}

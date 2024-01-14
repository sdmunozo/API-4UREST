﻿using NetShip.DTOs.Common;

namespace NetShip.Utilities
{
    public static class IQueryableExtensions
    {
        public static IQueryable<T> Paginate <T> (this IQueryable<T> queryable, PaginationDTO paginationDTO)
        {
            return queryable.Skip((paginationDTO.Page -1) * paginationDTO.RecordsPerPage).Take(paginationDTO.RecordsPerPage);
        }
    }
}

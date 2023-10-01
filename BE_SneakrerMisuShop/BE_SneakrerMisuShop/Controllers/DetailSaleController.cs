using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BE_SneakrerMisuShop.Bases;
using BE_SneakrerMisuShop.DatabaseContext;
using BE_SneakrerMisuShop.Enitites;
using BE_SneakrerMisuShop.Models;

namespace BE_SneakrerMisuShop.Controllers
{
    [ApiController]
    public class DetailSaleController : ControllerBase
    {
        private readonly MisuContext _misuContext;

        public DetailSaleController(MisuContext misuContext)
        {
            _misuContext = misuContext;
        }

        [HttpGet]
        [Route("api/v1/detail-sale/get-list")]
        public ResponseBase<List<DetailSaleDto>> GetList()
        {
            try
            {
                var response = _misuContext.DetailSales.Include(x => x.Sale).Include(x => x.Detail).ThenInclude(c => c.Product)
                    .Include(x => x.Detail).ThenInclude(s => s.Size)
                    .Include(x => x.Detail).ThenInclude(s => s.Color)
                    .Where(c => c.isDeleted == false).Select(c => new DetailSaleDto()
                    {
                        Id = c.Id,
                        SaleId = c.SaleId,
                        SaleName = c.Sale.Name,
                        ProductName = c.Detail.Product.Name,
                        SizeName = c.Detail.Size.Name,
                        ColorName = c.Detail.Color.Name,
                        Price = c.Detail.Price,
                        CreationTime = c.CreationTime,
                        DeletionTime = c.DeletionTime,
                        isDeleted = c.isDeleted,
                        LastModificationTime = c.LastModificationTime,
                        Status = c.Status,
                    }).ToList();

                return new ResponseBase<List<DetailSaleDto>>
                {
                    data = response,
                    status = 200
                };
            }
            catch (Exception ex)
            {
                return new ResponseBase<List<DetailSaleDto>>
                {
                    status = 500
                };
            }
        }

        [HttpGet]
        [Route("api/v1/detail-sale/get-list-by-sale-id/{saleId}")]
        public ResponseBase<List<DetailSaleDto>> GetList(int saleId)
        {
            try
            {
                var response = _misuContext.DetailSales.Include(x => x.Sale).Include(x => x.Detail).ThenInclude(c => c.Product)
                    .Include(x => x.Detail).ThenInclude(s => s.Size)
                    .Include(x => x.Detail).ThenInclude(s => s.Color)
                    .Where(c => c.isDeleted == false && c.SaleId == saleId && c.Status == 1).Select(c => new DetailSaleDto()
                    {
                        Id = c.Id,
                        SaleId = c.SaleId,
                        DetailId = c.DetailId,
                        SaleName = c.Sale.Name,
                        ProductName = c.Detail.Product.Name,
                        SizeName = c.Detail.Size.Name,
                        ColorName = c.Detail.Color.Name,
                        Price = c.Detail.Price,
                        CreationTime = c.CreationTime,
                        DeletionTime = c.DeletionTime,
                        isDeleted = c.isDeleted,
                        LastModificationTime = c.LastModificationTime,
                        Status = c.Status,
                    }).ToList();

                return new ResponseBase<List<DetailSaleDto>>
                {
                    data = response,
                    status = 200
                };
            }
            catch (Exception ex)
            {
                return new ResponseBase<List<DetailSaleDto>>
                {
                    status = 500
                };
            }
        }

        [HttpPost]
        [Route("api/v1/detail-sale")]
        public ResponseBase<CreateUpdateDetailSaleDto> Save(CreateUpdateDetailSaleDto input)
        {
            try
            {

                foreach (var x in input.DetailSales)
                {
                    var productDetail = _misuContext.ProductDetails.Where(c => c.isDeleted == false && c.Id == x.DetailId).FirstOrDefault();
                    if (productDetail is null)
                        return new ResponseBase<CreateUpdateDetailSaleDto>
                        {
                            status = 500
                        };
                    productDetail.isChecked = true;
                    _misuContext.ProductDetails.Update(productDetail);

                    var request = new DetailSale()
                    {
                        SaleId = input.SaleId,
                        DetailId = x.DetailId,
                        CreationTime = DateTime.Now,
                        isDeleted = false,
                        Status = 1
                    };

                    _misuContext.DetailSales.Add(request);
                    _misuContext.SaveChanges();
                }

                return new ResponseBase<CreateUpdateDetailSaleDto>
                {
                    data = input,
                    status = 200
                };
            }
            catch (Exception ex)
            {
                return new ResponseBase<CreateUpdateDetailSaleDto>
                {
                    status = 500
                };
            }
        }

        [HttpDelete]
        [Route("api/v1/detail-sale/{id}/{detailId}")]
        public ResponseBase<bool> Delete(int id = 0, int detailId = 0)
        {
            try
            {
                var productDetail = _misuContext.ProductDetails.Where(c => c.isDeleted == false && c.Id == detailId).FirstOrDefault();
                if (productDetail is null)
                    return new ResponseBase<bool>
                    {
                        status = 500
                    };
                productDetail.isChecked = false;
                _misuContext.ProductDetails.Update(productDetail);

                var result = _misuContext.DetailSales.FirstOrDefault(c => c.Id == id && c.isDeleted == false);

                if (result is null)
                    return new ResponseBase<bool>
                    {
                        status = 500
                    };

                _misuContext.DetailSales.Remove(result);

                _misuContext.SaveChanges();
                return new ResponseBase<bool>
                {
                    status = 200
                };
            }
            catch (Exception ex)
            {
                return new ResponseBase<bool>
                {
                    status = 500
                };
            }
        }

        [HttpGet]
        [Route("api/v1/detail-sale/get-detail-sale-by-detail/{detailId}")]
        public ResponseBase<DetailSaleDto> getDetailSaleByProductId(int detailId)
        {
            try
            {
                var response = _misuContext.DetailSales.Include(x => x.Sale).Include(x => x.Detail).ThenInclude(c => c.Product)
                    .Include(x => x.Detail).ThenInclude(s => s.Size)
                    .Include(x => x.Detail).ThenInclude(s => s.Color)
                    .Where(c => c.isDeleted == false && c.DetailId == detailId && c.Status == 1).Select(c => new DetailSaleDto()
                    {
                        Id = c.Id,
                        SaleId = c.SaleId,
                        DetailId = c.DetailId,
                        SaleName = c.Sale.Name,
                        ProductName = c.Detail.Product.Name,
                        SizeName = c.Detail.Size.Name,
                        ColorName = c.Detail.Color.Name,
                        Price = c.Detail.Price,
                        CreationTime = c.CreationTime,
                        DeletionTime = c.DeletionTime,
                        isDeleted = c.isDeleted,
                        LastModificationTime = c.LastModificationTime,
                        Status = c.Status,
                        ValueSale = c.Sale.Value
                    }).FirstOrDefault();

                if (response != null)
                {
                    return new ResponseBase<DetailSaleDto>
                    {
                        data = response,
                        status = 200
                    };
                }

                return new ResponseBase<DetailSaleDto>
                {
                    status = 200
                };



            }
            catch (Exception)
            {
                return new ResponseBase<DetailSaleDto>
                {
                    status = 500
                }; ;
            }
        }
    }
}

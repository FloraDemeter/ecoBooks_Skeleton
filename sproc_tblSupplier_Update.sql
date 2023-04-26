CREATE PROCEDURE sproc_tblSupplier_Update
	@SupplierNo int,
	@SupplierName varchar(50),
	@SupplyDate date,
	@SupplierAddress varchar(50),
	@SupplierContactNo int,
	@UK bit
AS
	update tblSupplier
	set SupplierName = @SupplierName,
	SupplyDate = @SupplyDate,
	SupplierAddress = @SupplierAddress,
	SupplierContactNo = @SupplierContactNo,
	UK = @UK
Where SupplierNo = @SupplierNo 




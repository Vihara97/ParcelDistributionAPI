CREATE PROCEDURE [dbo].[GetAllNonAssignedDrivers]
AS
BEGIN
    SET NOCOUNT ON;

select d.driverId, d.DriverFirstName, d.DriverLastName, d.Status
from Drivers d
left outer join Bookings b on b.DriverId != d.DriverId 
END
-- High Precision System and Date Time Functions

SELECT SYSDATETIME()		AS systemtime,			--System time 

	   SYSDATETIMEOFFSET()	AS systemtimeoffset,	--System time with the offset (in our case -04:00)
	  
       SYSUTCDATETIME()		AS systemutctime;		--System time (UTC 00:00)

-- Lower Precision System and Date Time Functions

SELECT CURRENT_TIMESTAMP	AS timestamp_			--Time at the moment of execution
	  
	  ,GETDATE()			AS date_				--System Time 
	  
      ,GETUTCDATE()			AS utcdate;				--System time (UTC 00:00)

-- Functions that get Date and Time parts

SELECT DATEPART(QUARTER, '2017-09-26 10:13:53.7242855 -04:00')			AS year_

	  ,DATENAME(month, '2017-09-26 10:13:53.7242855 -04:00')		AS month_
	    
      ,DATEPART(hour, '2017-09-26 10:13:53.7242855 -04:00')			AS day_
	    
      ,DATEPART(dayofyear, '2017-09-26 10:13:53.7242855 -04:00')	AS dayofyear_
	   
      ,DATEPART(weekday, '2017-09-26 10:13:53.7242855 -04:00')		AS dayofweek_
	  
	  ,DATEPART(millisecond, '00:00:01.1234567')					AS milliseconds
	  
	  ,DATEPART(microsecond, '00:00:01.1234567')					AS microseconds
	  
	  ,DATEPART(nanosecond,  '00:00:01.1234567')					AS nanoseconds;

--Functions that get Date and Time values from their parts
SELECT DATETIMEFROMPARTS (2017, 09, 26, 10, 01, 00, 0),
 
	   DATEFROMPARTS (2017, 09, 26),

	   DATETIME2FROMPARTS (2011, 8, 15, 14, 23, 44, 5, 7);


-- Other Examples

SELECT DATEADD(day, 10, GETDATE());

SELECT CONVERT(VARCHAR(30),GETDATE())

	  ,CONVERT(VARCHAR(10),GETDATE(),10)

	  ,CONVERT(VARCHAR(10),GETDATE(),110);

SELECT DATEDIFF(hour, GETDATE(), '2017-10-06 17:04:45.353')




USE Geography
GO

SELECT TOP(30) CountryName, Population 
FROM Countries
WHERE ContinentCode IN(
	SELECT ContinentCode
	FROM Continents
	WHERE ContinentName = 'Europe'
)
ORDER BY Population DESC, CountryName ASC

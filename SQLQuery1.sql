select * from rizlearnsql.dbo.Comments;
select * from Stock;

insert into dbo.stock(Symbol,CompanyName,Purchase,Lastdiv,Industry,MarketCap) values
--('TSLA','Tesla',100,2,'Automotive',23232323232);
    ('AAPL', 'Apple Inc.', 150, 0.96, 'Technology', 3000000000000),
    ('MSFT', 'Microsoft Corporation', 420, 3, 'Technology', 3100000000000),
    ('NVDA', 'NVIDIA Corporation', 120, 0.04, 'Semiconductors', 2800000000000);
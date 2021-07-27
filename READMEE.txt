DTO-- will have model classes ie encapsulated classes for tranmistting data to diffrent layers
BLL-- Logics
DAL--Database things
UI-- Controllers and views
Controller-- When we request a page in website, controller is responsible to return that request:
PostContext class in DAL is the database class
All DAO class will inherit from PostCOntext
	##BLL ra DAO define garepaxi Model define garnu parxa kinaki tesle data tranmit garxa
	COntroller maa instance DTO ko ani return garne tyo instance lai
	Load huda controller ko maathi ko Actionresult chalxa 
	data input garera sign in harepaxi [httppost] ko muni ko khulxa
	POST~~ CAR controller
Since For the Log Table we need to hold user ID so that all can access that why we are defining USerStatic Class

## J pani Add garna ko laagi
	DAO maa method define garne
	Entity framework ma add simple hunxa
	method maa table ko instance line
	Teslai userstatic sanga milaaune 
	db.logtable.Add(log)

Layout is used for common elements in each page
ViewBag.ProcessState le message dinxa k vayo vanera user lai
169//17.12

173.530

Controller ko view maa class instantiate gareko vaneko view maa tyo class pathaako

tag ko satta extra features use gareko hai 

20..28

185
186
187
188
feri garne,,,,,,,,



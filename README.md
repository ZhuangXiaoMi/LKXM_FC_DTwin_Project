#### 框架说明

框架参考 [eShopOnContainers](https://github.com/dotnet-architecture/eShopOnContainers) 结构搭建，微软官方源码包含在线商城的微服务，因此从零开始搭建，在开发过程中对适用代码进行逐步迁移。微服务将采用多种架构模式(简单CRUD、DDD、SignalR)和多种语言开发(PostgreSQL、Redis、文件)开发。

目录说明

 - [x] Services：微服务层
	 - [ ] LKXM.FCDTwin.Permission：用户权限
	 - [ ] LKXM.FCDTwin.Collect：数据采集服务
 - [x] AggregateServices：聚合服务层
	 - [ ] LKXM.FCDTwin.Aggregate
 - [x] ApiGateways：网关层
	 - [ ] LKXM.FCDTwin.Gateway
	 - [x] LKXM.FCDTwin.IdentityServer4
 - [x] Tests：测试层
	 - [ ] LKXM.FCDTwin.Test：单元测试
 - [x] WebApps：应用层
	 - [ ] LKXM.FCDTwin.Blazor：Web层
	 - [ ] LKXM.FCDTwin.App

引用技术

 - Consul：服务注册及发现
 - Polly：熔断降级
 - Ocelot：Api网关
 - IdentityServer4：身份验证授权
 - Quartz.NET：任务调度框架
 - Redis
 - RabbitMQ
 - Docker
 - gRPC

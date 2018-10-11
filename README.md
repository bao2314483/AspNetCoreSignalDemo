# AspNetCoreSignalDemo

使用nginx进行负载均衡配置如下
```
server {
  listen  8082;
  server_name  localhost;
  location / {
    proxy_pass   http://backweb;
    proxy_http_version 1.1;
    proxy_set_header Upgrade $http_upgrade;
    proxy_set_header Connection  $http_connection; 
    index  index.html index.htm;
  }
}
 ```

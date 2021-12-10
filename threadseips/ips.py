import ipaddress

# ip = '192.168.0.1'
rede = '192.168.0.0/4'

# endereco = ipaddress.ip_address(ip)
rede_ende = ipaddress.ip_network(rede, strict=False)

# print(endereco + 2000)

for ip in rede:
    print(rede)

# print(rede)

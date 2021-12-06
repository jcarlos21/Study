import os

print("#" * 60)
ip_ou_host = input("Digite o Ip ou host a ser verificado: ")
# os.system(f'ping -n 6 {ip_ou_host}')
os.system('ping -n 6 {}'.format(ip_ou_host))
print("-" * 60)

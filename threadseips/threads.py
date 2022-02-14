from threading import Thread  # permite o paralelismo com processos (ou seja, vários processos sendo executados ao
# mesmo tempo)
import time


def carro(velocidade, piloto):
    trajeto = 0
    while trajeto <= 100:
        trajeto += velocidade
        time.sleep(0.5)
        print('Piloto: {} Km: {}'.format(piloto, trajeto))


t_carro1 = Thread(target=carro, args=[1, 'Bruno'])
t_carro2 = Thread(target=carro, args=[2, 'Python'])

t_carro1.start()
t_carro2.start()

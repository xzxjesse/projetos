numeroa, numerob, numeroc = input('').split()

numeroa=float(numeroa)
numerob=float(numerob)
numeroc=float(numeroc)

delta = (numerob**2-4*numeroa*numeroc)
if numeroa==0.0 or delta<0:
    print('Impossivel calcular')
else:
    x1=(-numerob+(delta)**(1/2))/(2*numeroa)
    x2=(-numerob-(delta)**(1/2))/(2*numeroa)
    print('R1 = {:.5f}'.format (x1))
    print('R2 = {:.5f}'.format (x2))
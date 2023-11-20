total_dias = int(input())

#ANOS
anos=total_dias//365
total_dias=total_dias-anos*365 
#MESES
meses=total_dias//30
total_dias=total_dias-meses*30 
#DIAS
dias=total_dias

print('{} ano (s)' .format (anos))
print('{} mes (es)' .format(meses))
print('{} dia(S)'.format(dias))
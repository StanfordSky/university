k=0
s=0
count = 0
def search(ch,name):
    y = int(ch)
    global count
    if (  (y > k) & (y < s) ):
        print(y)
        count=count+1
    print("Колличество радиостанций, частоты которых входят в диапазон:",count)
class RadStation:
    def __init__(self, one, two):
        self.name=one
        self.frequency=two
    def show(self):
        namestr=self.name
        print('\nНазвание радиостанции',self.name, "Частота:", self.frequency)
    def poinr(selfs):
        str2=selfs.name
        ch =selfs.frequency
        xad=search(ch,str2)
print('Введите диапазаон:')
k=int(input())
s=int(input())
well = RadStation("Radio Hill",40.555)
well.show()
well.poinr()
sqtr =RadStation("Станция 2",90)
sqtr.show()
sqtr.poinr()
yt=RadStation("Рыба", 76)
yt.show()
yt.poinr()
tr=RadStation("Мы тут",100)
tr.show()
tr.poinr()
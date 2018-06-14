include "include01.ms"

fn SayHello2 = 
(
	include "include01.ms"
)

filein "include02.ms"

sayHello()
sayHello2()


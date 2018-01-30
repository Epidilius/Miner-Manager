""""This is a script to help perform auto start and stop of hashing operations for hashing power rental.
    This Script only requires a functional installation of Python3 with no extra dependencies.
    If you appreciate this script, I gladly accept tips at GRLC:GKtudBxR36CFs1mGQNKmGc5VBQQTbaWfFy
    -/u/meh12345hey                                                                                 """
from os import system, startfile
import time
import threading
from csv import reader
from sys import maxsize


def terminate(mining_prog):
    """Terminate the mining process after time elapses"""
    print("Mining Finished")
    system('taskkill /f /im ' + mining_prog)


mining_prog = "ccminer-x64.exe"
filename = input("Input config file name:\t")
inputs = []
#perform import of Comma Seperate Value (CSV) file
with open(filename) as config:
    read = reader(config)
    for row in read:
        inputs.append(row)
#display information for hashing runs
init = inputs.pop(0)
init_desc = ["Run with speed boost:\t", "Number of miners:\t","Max GPU Temp:\t"]
for i in range(0, len(init)):
    print(init_desc[i] + str(init[i]))
inputs_desc = ["Pool Address:\t","Wallet Address:\t",'Runtime in Minutes:\t']
print("<<<<------------------------------------------------------------>>>>")
for r in range(0, len(inputs)):
    print("Miner " + str(r))
    for i in range(0, len(inputs[r])):
        print("\t"+inputs_desc[i]+inputs[r][i])
#Define launch argument components
algo = " --algo=scrypt:10"
speed_boost = " --lookup-gap=2"     #<<== Works on some Nvidia GPUs, set launch config to false to disable
DO_SPEED_BOOST = init[0]            #<<== Set this option to False if the above slows your hashing
z = 0
try:
    while z < len(inputs):
        tmp = 0
        pool_address = " -o " + inputs[z][0]        #load Pool Address
        wallet_address = " -u " + inputs[z][1]      #Load Wallet Address
        temp = init[1]
        args = mining_prog + algo
        if DO_SPEED_BOOST:
            args += speed_boost + pool_address + wallet_address + " --max-temp=" + str(temp)
        else:
            args += pool_address + wallet_address  + " --max-temp=" + str(temp)
        #^^ Finish assembling launch arguments ^^
        interval = 60*30        #<<== An Elapsed time notification will appear every 30 mins
        print("<<<<------------------------------------------------------------>>>>")
        print("Starting Mining Sequence ==>> Address: " + inputs[z][1])
        print("<<<<------------------------------------------------------------>>>>")
        launcher = 'miner.bat'
        f = open('miner.bat', 'w')
        f.write(args)
        f.close()
        startfile(launcher)
        start = int(time.time())
        runtime = 0
        if int(inputs[z][2]) > 0:
            runtime = int(inputs[z][2])*60
            timer = threading.Timer(runtime, terminate, [mining_prog])        #<<== This timer thread kills mining
            #runtime = time.strptime(inputs[z][2], '%d:%H:%M')
            #timer = threading.Timer((runtime.tm_mday * 24 * 60 + runtime.tm_hour * 60 + runtime.tm_min), terminate, [mining_prog])        #<<== This timer thread kills mining
            timer.start()                                       #<<== Once the total time is reached
        else:
            runtime = maxsize                                   #Use -1 let it run forever
        t = 0
        while int(time.time()) - start < runtime:               #Time check, how much time is elapsed
            tmp = (int(time.time())-start)
            if tmp % interval == 0:
                if not t == tmp:
                    remaining = int((runtime - tmp)/60)
                    print("<<<<Elapsed: " + str(int(tmp/60)) + " Mins. Remaining: " + str(remaining) + " Mins>>>>")
                    t = tmp
        time.sleep(5)
        z+=1
except KeyboardInterrupt:
    quit = input("You pressed Ctr + C, are you sure you want to quit? (Y/N):\n")    #<<==Handles graceful killing
    if 'y' == quit.lower():                                                         #Of entire program
        terminate(mining_prog)
        exit(0)
MinerManager

A GUI to help you rent out your hashing power, or even just mine for yourself.

Designed to pool mine GRLC with an NVIDIA GPU, I don't know if it would work elsewhere.

The Application folder is where I keep the most recent build. 

It closes to the system tray, right click the icon and hit "Exit" to close it for good. I did this so it could be out of the way while running.
----  ----  ----  ----
This works in four steps:
1) It grabs info from the top of the queue
2) It makes a bat file with that info
3) It launches that file and starts a timer
4) When the timer reaches zero, repeat step 1 (if nothing in queue, it just does nothing)
----  ----  ----  ----
Control Explanations:

//Fields

- Target Pool: The pool you want to mine in (format like: stratum+tcp://us.pool.garlicsoup.xyz:3333)
- Target Wallet: The wallet your mined garlic will go to 
- Duration: HH (hours), MM (minutes), and SS (seconds). The duration is the total of all three fields. Use numbers, not words. Leave empty for no time limit on the miner
- Use Lookup Gap: If this is checked, it will add "--lookup-gap 2" to your bat
- Algorithm: The algorithm you want to mine. Leave as scrypt:10 for GRLC

//Buttons

- Add to Queue: Takes the information you inputted and adds it to your queue
- Start: If you stopped the miner, this starts it back up and resumes the timers
- Stop: Pauses your timer, kills your miner. 
- Skip: Ends the current job
- Up Arrow: Moves the selected job up the queue
- Down Arrow: Moves the selected job down the queue
- Checkmark: Starts your mining jobs (starting at the top of the queue)
- Cross: Removes selected job from the queue

//Config

- MinerPath: The directory you have ccminer in
- CCMinerName: The name of your ccminer
- MinerName: What you want your bat file to be called
- CatalystName: The name of your catalyst file. This starts the bat file (which runs your miner) to avoid locking issues
- MaxTemp: The max temperature of your GPU

----  ----  ----  ----
Setup:

//Option 1:

Change the two paths in MinerManager.exe.config to match your ccminer path

//Option 2:

Move your ccminer stuff into the path found in MinerManager.exe.config (C:\Crypto\Tools\ccminer-x64-2.2.4-cuda9\)
----  ----  ----  ----
Pool List: https://pandawanfr.github.io/GarlicRecipes/pool-mining.html#main-net
----  ----  ----  ----
//TODO:

Default values that you can set. Open up the program, your info is there in the queue, hit start

Better icons

Queue saving, so you can quit and reopen it later

Actual miner pausing, instead of killing

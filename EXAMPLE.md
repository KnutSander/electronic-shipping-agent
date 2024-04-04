Given the following input, let's try and pack the anchorage:
```sh
$ curl -X GET https://esa.instech.no/api/fleets/random
```

This will have produced a JSON response with data similar to this:
```json
{
  "anchorageSize": {
    "width": 12,
    "height": 15
  },
  "fleets": [
    {
      "singleShipDimensions": { "width": 6, "height": 5 },
      "shipDesignation": "LNG Unit",
      "shipCount": 2
    },
    {
      "singleShipDimensions": { "width": 3, "height": 12 },
      "shipDesignation": "Science & Engineering Ship",
      "shipCount": 5
    }
  ]
}
```

This response means that the anchorage is a rectangle which is 12x15 units and we have 
**7** ships in total to pack into it.
Let's represent LNG Units with letter "L" and Science & Engineering ships with letter S.
This is the graphical representation of our task:

```
Anchorage:        Ships to place:

............      LLLLLL      SSS
............      LLLLLL      SSS
............      LLLLLL x2   SSS
............      LLLLLL      SSS
............      LLLLLL      SSS
............                  SSS
............                  SSS  x5
............                  SSS
............                  SSS
............                  SSS
............                  SSS
............                  SSS
............
............
............
```

Let's try and place one of the LNG Units onto the anchorage:
```
Anchorage:      Ships to place:

LLLLLL......      LLLLLL      SSS
LLLLLL......      LLLLLL      SSS
LLLLLL......      LLLLLL x1   SSS
LLLLLL......      LLLLLL      SSS
LLLLLL......      LLLLLL      SSS
............                  SSS
............                  SSS  x5
............                  SSS
............                  SSS
............                  SSS
............                  SSS
............                  SSS
............
............
............
```

As you can see, we have one more LNG unit to place and still all of 5 science ships remain. Let's place another LNG unit:
```
Anchorage:      Ships to place:

LLLLLL......            SSS
LLLLLL......            SSS
LLLLLL......            SSS
LLLLLL......            SSS
LLLLLL......            SSS
LLLLLL......            SSS
LLLLLL......            SSS  x5
LLLLLL......            SSS
LLLLLL......            SSS
LLLLLL......            SSS
............            SSS
............            SSS
............
............
............
```
We have only science ships left to place. Let's place two of them side-by-side:
```
Anchorage:      Ships to place:

LLLLLLSSSSSS            SSS
LLLLLLSSSSSS            SSS
LLLLLLSSSSSS            SSS
LLLLLLSSSSSS            SSS
LLLLLLSSSSSS            SSS
LLLLLLSSSSSS            SSS
LLLLLLSSSSSS            SSS  x3
LLLLLLSSSSSS            SSS
LLLLLLSSSSSS            SSS
LLLLLLSSSSSS            SSS
......SSSSSS            SSS
......SSSSSS            SSS
............
............
............
```

We can try and fit in one last science ship in this round by rotating it 90 degrees:
```
Anchorage:      Ships to place:

LLLLLLSSSSSS            SSS
LLLLLLSSSSSS            SSS
LLLLLLSSSSSS            SSS
LLLLLLSSSSSS            SSS
LLLLLLSSSSSS            SSS
LLLLLLSSSSSS            SSS
LLLLLLSSSSSS            SSS  x2
LLLLLLSSSSSS            SSS
LLLLLLSSSSSS            SSS
LLLLLLSSSSSS            SSS
......SSSSSS            SSS
......SSSSSS            SSS
SSSSSSSSSSSS
SSSSSSSSSSSS
SSSSSSSSSSSS
```

Since we can't possibly fit any more ships in this round, let's go to the next round. In the beginning of placement round, anchorage is emptied out. We can now place the last remaining shience ships into the anchorage:
```
Anchorage:      Ships to place:

............
.SSS........
.SSS....SSS.
.SSS....SSS.
.SSS....SSS.
.SSS....SSS.
.SSS....SSS.        All done!
.SSS....SSS.
.SSS....SSS.
.SSS....SSS.
.SSS....SSS.
.SSS....SSS.
.SSS....SSS.
........SSS.
............
```

Now we can conclude that we are able to anchor all the ships in just 2 rounds.
Our placement looks like this:

```
   ROUND 1              ROUND 2

LLLLLLSSSSSS         ............
LLLLLLSSSSSS         .SSS........
LLLLLLSSSSSS         .SSS....SSS.
LLLLLLSSSSSS         .SSS....SSS.
LLLLLLSSSSSS         .SSS....SSS.
LLLLLLSSSSSS         .SSS....SSS.
LLLLLLSSSSSS         .SSS....SSS.
LLLLLLSSSSSS         .SSS....SSS.
LLLLLLSSSSSS         .SSS....SSS.
LLLLLLSSSSSS         .SSS....SSS.
......SSSSSS         .SSS....SSS.
......SSSSSS         .SSS....SSS.
SSSSSSSSSSSS         .SSS....SSS.
SSSSSSSSSSSS         ........SSS.
SSSSSSSSSSSS         ............
```

Now try and solve this problem for a bigger input set! Good luck!
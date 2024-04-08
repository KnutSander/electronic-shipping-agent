# Task

Create an API with working endpoints to solve a functional problem. The specifications will be stated below.

# Backstory: Electronic Shipping Agent

We have recently opened a robotics laboratory inside our organisation and we have already gotten a lead with a potential customer in the shipping business.
The customer is a co-owner of a local port and anchorage and they need help automating their ship docking solution. For the longest time they have employed
a shipping agent who was responsible for placing the ships in the correct spots in the anchorage, but this is a very demanding job, that requires a person
to constantly solve an [NP problem](https://en.wikipedia.org/wiki/NP_(complexity)) in a nearly optimal way. As a result, the shipping agent has gone full rogue and locked themselves up in a room and reciting [Lance Fortnow's work](https://wayback.archive-it.org/all/20110224135337/http://people.cs.uchicago.edu/~fortnow/papers/pnp-cacm.pdf).

We have the necessary competence to solve the problem for them and our android engineers have already performed the scans of the agent's visage to make a full 3D-printed android which is going to replace them. We only need now to solve the last remaining issue of actually optimising the layout of the port.

This is where you come in.
```
Given a list of vessels and their dimensions, develop an electronic shipping agent API,
capable of calculating the optimal (or near-optimal) arrangement of vessels inside
a rectangular anchorage area.

The anchorage can't fit all ships in one round.

The API SHOULD respond with a minimal number of rounds that it would take for the entire
input list of vessels to be anchored.

The API MAY additionally respond with every optimal layout of ships for every round. The
schema of the response is up to you to decide upon.

The API MUST be unit tested.
```

You can find a simple example going through the solution manually here:
[EXAMPLE.md](/EXAMPLE.md).

You can assume the following:
- Every ship can be placed into anchorage. No ship in the input list will be larger than the anchorage.
- Optimal solution is welcome, but not necessary. Most of the time a "good enough" solution is going to solve the case.
- Ships can be rotated before placement.
- All of the ships enter and leave the anchorage at the same time, so there is no need to worry about solving any pathing-related issues.

We have asked our market researcher to supply us with sufficient test data for you to validate your solution. Test cases are served via a web API which you can access on this URI: https://esa.instech.no

The API is live and public and will emit a random test case upon request. You can use your favourite tool like `curl` or `Postman` to inspect the schema of the test data.

## Bonus points
- Integration testing of the API.
- API endpoint doc comments or a swagger endpoint with example usages.
- Logging in the core application part detailing the process of optimisation.
- Proper development history in git with meaningful commit messages and/or branching.
- CI/CD pipeline into the cloud provider of your choice.

## Remarks about presenting and implementing the solution
- When presenting the solution we want you to treat it as if you were building an actual production system. That means no secrets must be stored in git and solution quality has to be as good as you can make it.
- When making assumptions about the domain or implementation, note them down. It is acceptable to cut corners in edge cases or unlikely scenarios, but you should be aware of those limitations.
- Be ready to run through your solution and explain your reasoning to us. We value a good conversation.
- Technology choice is up to you, but be aware that we mostly work with `.NET`.
- There is nothing wrong with learning from others, but we would appreciate it if you didn't use any generative language models to help you with the solution outside of menial typing (like adding docs). We want this assignment to be a realistic representation of your skill level.

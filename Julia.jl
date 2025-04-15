# Agent-Based Model in Julia

# Define Agent struct
mutable struct Agent
    id::Int
    x::Float64
    y::Float64
    energy::Float64
end

# Initialize Agents
function initialize_agents(n::Int, space_width::Float64, space_height::Float64)
    agents = [Agent(i, rand() * space_width, rand() * space_height, 100.0) for i in 1:n]
    return agents
end

# Function to calculate distance between two agents
function distance(agent1::Agent, agent2::Agent)
    return sqrt((agent1.x - agent2.x)^2 + (agent1.y - agent2.y)^2)
end
function initialize_agents(n::Int, space_width::Float64, space_height::Float64)
    if n <= 0
        throw(ArgumentError("Number of agents must be a positive integer."))
    end
    if space_width <= 0.0 || space_height <= 0.0
        throw(ArgumentError("Space dimensions must be positive non-zero values."))
    end
    agents = [Agent(i, rand() * space_width, rand() * space_height, 100.0) for i in 1:n]
    return agents
end
# Function to update agent position (random walk)
function move!(agent::Agent, step_size::Float64, space_width::Float64, space_height::Float64)
    dx = randn() * step_size
    dy = randn() * step_size

    agent.x += dx
    agent.y += dy

    # Boundary conditions: Reflective boundaries
    if agent.x < 0.0
        agent.x = -agent.x
    elseif agent.x > space_width
        agent.x = 2*space_width - agent.x
    end

    if agent.y < 0.0
        agent.y = -agent.y
    elseif agent.y > space_height
        agent.y = 2*space_height - agent.y
    end
    agent.energy -= 1 # Energy cost of movement
end

# Interaction function (example: energy transfer)
function interact!(agent1::Agent, agent2::Agent, interaction_distance::Float64, transfer_amount::Float64)
    if distance(agent1, agent2) < interaction_distance
        if agent1.energy > 0 && agent2.energy < 200
            agent1.energy -= transfer_amount
            agent2.energy += transfer_amount
        end
    end
end

# Simulation step
function step!(agents::Vector{Agent}, space_width::Float64, space_height::Float64, step_size::Float64, interaction_distance::Float64, transfer_amount::Float64)
    # Move all agents
    for agent in agents
        move!(agent, step_size, space_width, space_height)
    end

    # Interactions
    for i in 1:length(agents)
        for j in (i+1):length(agents)
            interact!(agents[i], agents[j], interaction_distance, transfer_amount)
        end
    end
end

# Simulation parameters
num_agents = 100
space_width = 100.0
space_height = 100.0
step_size = 1.0
interaction_distance = 5.0
transfer_amount = 5.0
num_steps = 100

# Initialize agents
agents = initialize_agents(num_agents, space_width, space_height)

# Run simulation
for t in 1:num_steps
    step!(agents, space_width, space_height, step_size, interaction_distance, transfer_amount)
    # Optional: Collect data or visualize the simulation here
    # println("Step: $t")
end

# Example: Print final energy levels of agents
for agent in agents
    println("Agent $(agent.id): Energy = $(agent.energy)")
end

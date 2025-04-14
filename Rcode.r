# Simulate stock prices using Geometric Brownian Motion

# Parameters
S0 <- 100       # Initial stock price
mu <- 0.1       # Expected return
sigma <- 0.2     # Volatility
T <- 1          # Time horizon (1 year)
n <- 252        # Number of time steps (daily)
dt <- T/n       # Time step size

# Number of simulations
num_simulations <- 10

# Function to simulate a single stock price path
simulate_stock_price <- function(S0, mu, sigma, dt, n) {
  # Generate random normal values
  Z <- rnorm(n)
  
  # Initialize stock price path
  S <- numeric(n+1)
  S[1] <- S0
  
  # Simulate stock prices
  for (i in 1:n) {
    S[i+1] <- S[i] * exp((mu - 0.5 * sigma^2) * dt + sigma * sqrt(dt) * Z[i])
  }
  
  return(S)
}

# Simulate multiple stock price paths
stock_paths <- matrix(NA, nrow = n+1, ncol = num_simulations)
for (i in 1:num_simulations) {
  stock_paths[, i] <- simulate_stock_price(S0, mu, sigma, dt, n)
}

# Plot the simulated stock price paths
time <- seq(0, T, length.out = n+1)
matplot(time, stock_paths, type = "l", 
        xlab = "Time (Years)", ylab = "Stock Price",
        main = "Simulated Stock Prices using GBM",
        col = rainbow(num_simulations), lty = 1)
abline(h = S0, col = "black", lty = 2)  # Add a line for the initial stock price
legend("topright", legend = paste("Simulation", 1:num_simulations),
       col = rainbow(num_simulations), lty = 1, cex = 0.7)

# Calculate the average stock price path
average_path <- rowMeans(stock_paths)

# Add the average path to the plot
lines(time, average_path, col = "black", lwd = 2)
legend("bottomright", legend = "Average Path", col = "black", lwd = 2, cex = 0.7)

# Calculate and print the final stock prices
final_prices <- stock_paths[n+1, ]
print("Final Stock Prices:")
print(final_prices)

# Calculate and print summary statistics of final stock prices
print("Summary Statistics of Final Stock Prices:")
print(summary(final_prices))

# Calculate the probability of the stock price being above a certain level (e.g., 120)
threshold <- 120
probability_above <- mean(final_prices > threshold)
print(paste("Probability of Stock Price >", threshold, ":", probability_above))

# End of code

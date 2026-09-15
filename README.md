[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT)
# Marketplace Order Gateway. 

The project is using .net 10 with Clean Architecture architechture.
It is a layer for orders for a marketplace.
It provides reliability because once we've accepted an order, it gets delivered downstream exactly once, eventually using the transactional outbox pattern.
Today the project has just the Clean Architechture implementation.

## License
This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.
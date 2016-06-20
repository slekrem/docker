#!/bin/bash

DOCKER_MACHINE_NAME=registry
DOCKER_MACHINE_STATE=$(docker-machine status $DOCKER_MACHINE_NAME)

if [[ -z $DOCKER_MACHINE_STATE ]]; then
    docker-machine create -d virtualbox $DOCKER_MACHINE_NAME
fi

eval $(docker-machine env $DOCKER_MACHINE_NAME)
DOCKER_MACHINE_IP=$(docker-machine ip $DOCKER_MACHINE_NAME)

echo "ip: $DOCKER_MACHINE_IP"
docker-compose up --build

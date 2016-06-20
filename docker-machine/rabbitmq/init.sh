#!/bin/bash

DOCKER_MACHINE_NAME=rabbitmq
DOCKER_MACHINE_STATE=$(docker-machine status $DOCKER_MACHINE_NAME)

if [[ -z $DOCKER_MACHINE_STATE ]]; then
  docker-machine create -d virtualbox $DOCKER_MACHINE_NAME
elif [[ $DOCKER_MACHINE_STATE == "stopped" ]]; then
  docker-machine start $DOCKER_MACHINE_NAME
fi

eval $(docker-machine env $DOCKER_MACHINE_NAME)

docker-compose up --build

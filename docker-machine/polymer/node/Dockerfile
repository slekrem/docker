FROM node:4.4.5

RUN npm install -g bower
RUN npm install -g polymer-cli

COPY ./src/ ./app/
COPY ./docker-entrypoint.sh ./app/docker-entrypoint.sh

WORKDIR ./app/
RUN chmod -R +x /app

VOLUME [ "/app/build/bundled", "/app/build/unbundled" ]

CMD [ "/bin/bash" ]
ENTRYPOINT [ "/app/docker-entrypoint.sh" ]

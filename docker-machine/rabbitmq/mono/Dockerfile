FROM mono:latest

COPY /src/ /src/
COPY /docker-entrypoint.sh /docker-entrypoint.sh
RUN chmod +x docker-entrypoint.sh

WORKDIR /src/

CMD /bin/bash
ENTRYPOINT /docker-entrypoint.sh

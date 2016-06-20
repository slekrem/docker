FROM mono:latest

COPY /src/ /src/
COPY /docker-entrypoint.sh /docker-entrypoint.sh
RUN chmod +x /docker-entrypoint.sh

ADD https://raw.githubusercontent.com/vishnubob/wait-for-it/master/wait-for-it.sh /wait-for-it.sh
RUN chmod +x /wait-for-it.sh

WORKDIR /src/

CMD /bin/bash
ENTRYPOINT /docker-entrypoint.sh

#!/bin/bash

# Script til at pushe til Git med brugerinput

# Farver til output
GREEN='\033[0;32m'
RED='\033[0;31m'
NC='\033[0m' # No Color

# Spørg brugeren om commit besked
echo "Indtast din commit besked:"
read commitMessage

# Tilføj filer til Git
if git add .; then
    echo -e "${GREEN}Filer tilføjet til Git${NC}"
else
    echo -e "${RED}Fejl ved tilføjelse af filer${NC}"
    exit 1
fi

# Commit med brugerens besked
if git commit -m "$commitMessage"; then
    echo -e "${GREEN}Commit succesfuld${NC}"
else
    echo -e "${RED}Fejl ved commit${NC}"
    exit 1
fi

# Tjek nuværende branch
current_branch=$(git branch --show-current)
echo "Du er på branch: $current_branch"

# Push til repository
if git push; then
    echo -e "${GREEN}Ændringer er blevet pushet til Git!${NC}"
else
    echo -e "${RED}Fejl ved push${NC}"
    exit 1
fi